package com.unipi.rdkn.mypois;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.content.Intent;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    Button insert, search, update, delete, show;
    String[] but = {"insert", "search", "update", "delete", "showall"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        insert = findViewById(R.id.insert_button);
        search = findViewById(R.id.search_button);
        update = findViewById(R.id.update_button);
        delete = findViewById(R.id.delete_button);
        show = findViewById(R.id.showall_button);
        insert.setText(but[0]);
        search.setText(but[1]);
        update.setText(but[2]);
        delete.setText(but[3]);
        show.setText(but[4]);
        insert.setOnClickListener(this);
        search.setOnClickListener(this);
        update.setOnClickListener(this);
        delete.setOnClickListener(this);
        show.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        //start second activity
        Intent intent = new Intent(this, SecondActivity.class);
        if(view.getId()==insert.getId()){
            intent.putExtra("op",but[0]);
        }
        else if(view.getId()==search.getId()){
            intent.putExtra("op",but[1]);

        }else if(view.getId()==update.getId()){
            intent.putExtra("op",but[2]);

        }else if(view.getId()==delete.getId()){
            intent.putExtra("op",but[3]);
        }else{
            intent.putExtra("op",but[4]);
        }
        startActivity(intent);
    }
}