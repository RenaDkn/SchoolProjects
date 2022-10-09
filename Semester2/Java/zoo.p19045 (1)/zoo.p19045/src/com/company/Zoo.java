package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Zoo extends Mes{
    public void myAnimals(){
        List<Animal> listazwwn = new ArrayList<>();
        try {
            FileInputStream fileInputStream = new FileInputStream("zwa.ser");
            ObjectInputStream objectInputStream= new ObjectInputStream(fileInputStream);
            fileInputStream.close();
            objectInputStream.close();
        } catch (Exception e) {
            try {
                FileOutputStream fileOutputStream = new FileOutputStream("zwa.ser");
                ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
                objectOutputStream.writeObject(listazwwn);
                objectOutputStream.close();
                fileOutputStream.close();
            } catch (Exception f) {

            }
        }

    }

    @Override
    public void mini() {
        System.out.println("ΑΥΤΑ ΕΙΝΑΙ ΤΑ ΖΩΑ ΜΑΣ:");
    }
}
