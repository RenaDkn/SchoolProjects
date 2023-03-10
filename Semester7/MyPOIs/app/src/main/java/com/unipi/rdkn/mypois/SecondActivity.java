package com.unipi.rdkn.mypois;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import androidx.annotation.NonNull;
import androidx.core.app.ActivityCompat;
import android.Manifest;
import android.app.AlertDialog;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.sql.Timestamp;

public class SecondActivity extends AppCompatActivity implements LocationListener {
    TextView titleT, placeT, categoryT, descriptionT;
    SQLiteDatabase db;
    Button button;
    EditText titleP, categoryP, descriptionP;
    String t, user_title, user_category, user_description;
    Double x, y;
    Timestamp timestamp;
    LocationManager locationManager;
    int rq= 123;
    boolean first;
    String[]data={"Title:","Timestamp:","X:","Y:","Category:","Description:"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);
        locationManager = (LocationManager) getSystemService(LOCATION_SERVICE);
        first=false;
        //database
        db = openOrCreateDatabase("DB1.db", MODE_PRIVATE, null);
        db.execSQL("Create table if not exists PLACES(" +
                "title TEXT PRIMARY KEY,timestamp TEXT,locationX TEXT,locationY TEXT,category TEXT,description ΤΕΧΤ)");
        titleT = findViewById(R.id.result_text);
        t = getIntent().getStringExtra("op");
        button = findViewById(R.id.button);
        button.setText(t);
        placeT = findViewById(R.id.placetitle_text);
        placeT.setText("Title");
        categoryT = findViewById(R.id.category_text);
        categoryT.setText("Category");
        descriptionT = findViewById(R.id.description_text);
        descriptionT.setText("Description");
        titleP = findViewById(R.id.title_plaintext);
        categoryP = findViewById(R.id.category_plaintext);
        descriptionP = findViewById(R.id.description_plaintext);

        //appearence of activity
        if (t.equals("search") || t.equals("delete")) {
            categoryT.setVisibility(View.INVISIBLE);
            descriptionT.setVisibility(View.INVISIBLE);
            categoryP.setVisibility(View.INVISIBLE);
            descriptionP.setVisibility(View.INVISIBLE);

        }
        if (t.equals("showall")) {
            placeT.setVisibility(View.INVISIBLE);
            categoryT.setVisibility(View.INVISIBLE);
            descriptionT.setVisibility(View.INVISIBLE);
            titleP.setVisibility(View.INVISIBLE);
            categoryP.setVisibility(View.INVISIBLE);
            descriptionP.setVisibility(View.INVISIBLE);
        }
        if (t.equals("update")) {
            categoryT.setVisibility(View.INVISIBLE);
            categoryP.setVisibility(View.INVISIBLE);
            descriptionT.setText("New Description");

        }
        button.setOnClickListener(new View.OnClickListener() {
            //button click
            @Override
            public void onClick(View view) {
                if (t.equals("insert")) {
                    //checκ for empty fields
                    if (titleP.getText().toString().length() > 0 && categoryP.getText().toString().length() > 0 && descriptionP.getText().toString().length() > 0) {
                        timestamp = return_timestamp();
                        user_title = String.valueOf(titleP.getText());
                        user_category = String.valueOf(categoryP.getText());
                        user_description = String.valueOf(descriptionP.getText());
                        getLocation();

                    }else{
                        showMessage("Fields","Please type in the fields!");
                    }

                } else if (t.equals("search")) {
                    //checκ for empty fields
                    if (titleP.getText().toString().length()>0 ) {
                        user_title = String.valueOf(titleP.getText());
                        Cursor cursor = db.rawQuery("Select * from PLACES WHERE title=?", new String[]{user_title});
                        StringBuilder builder = new StringBuilder();
                        while (cursor.moveToNext()) {
                            for (int i = 0; i < 6; i++) {
                                builder.append(cursor.getString(i)).append(" ");
                            }
                            builder.append("\n");
                        }
                        titleT.setVisibility(View.VISIBLE);
                        //checκ if found
                        if (builder.length()!=0){
                            titleT.setText(builder.toString());
                        }else
                        {
                            titleT.setText("Not found!");
                        }

                    }else{
                    showMessage("Fields","Please type in the fields!");
                }

                } else if (t.equals("update")) {
                    //checκ for empty fields
                    if (titleP.getText().toString().length()>0  && descriptionP.getText().toString().length()>0) {
                        user_title = String.valueOf(titleP.getText());
                        user_category = String.valueOf(categoryP.getText());
                        user_description = String.valueOf(descriptionP.getText());
                        db.execSQL("UPDATE PLACES SET description = ? WHERE title=?;", new String[]{user_description, user_title});
                        showMessage("Update","Update done!");
                    }else{
                        showMessage("Fields","Please type in the fields!");
                    }


                } else if (t.equals("delete")) {
                    //checκ for empty fields
                    if (titleP.getText().toString().length()>0) {
                        user_title = String.valueOf(titleP.getText());
                        db.execSQL("DELETE FROM PLACES WHERE title==?", new String[]{user_title});
                        showMessage("Delete","Delete done!");
                    }else{
                        showMessage("Fields","Please type in the fields!");
                    }


                } else {
                    int count = 1;
                    Cursor cursor = db.rawQuery("Select * from PLACES", null);
                    StringBuilder builder = new StringBuilder();
                    while (cursor.moveToNext()) {
                        builder.append("Place" + count + ":");
                        for (int i = 0; i < 6; i++) {
                            builder.append(data[i]).append(cursor.getString(i)).append(" ");
                        }
                        builder.append("\n");
                        count++;
                    }
                    titleT.setVisibility(View.VISIBLE);
                    titleT.setText(builder.toString());
                }

            }
        });
    }
    public void showMessage(String title, String text) {
        //Shoe message to user void
        new AlertDialog.Builder(this)
                .setCancelable(true)
                .setTitle(title)
                .setMessage(text)
                .show();
    }

    public Timestamp return_timestamp() {
        //return current time and date
        timestamp = new Timestamp(System.currentTimeMillis());
        return timestamp;
    }

    public void getLocation() {
        //request current location
        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_COARSE_LOCATION) != PackageManager.PERMISSION_GRANTED) {
            first=true;
            ActivityCompat.requestPermissions(this,new String[]{Manifest.permission.ACCESS_FINE_LOCATION},rq);
            return;
        }
        first=false;
        locationManager.requestLocationUpdates(LocationManager.GPS_PROVIDER, 0, 0, this);
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        if(requestCode==rq){
            if (grantResults.length>0 && grantResults[0]==PackageManager.PERMISSION_GRANTED){
                if(first){
                    getLocation();
                }
            }
        }
    }

    @Override
    public void onLocationChanged(@NonNull Location location) {
        x=location.getLatitude();
        y=location.getLongitude();
        locationManager.removeUpdates(this);
        db.execSQL("Insert into PLACES Values(?,?,?,?,?,?)",new String[]{user_title,timestamp.toString(),x.toString(),y.toString(),user_category,user_description});
        showMessage("Insert","Insert done!");
    }

}