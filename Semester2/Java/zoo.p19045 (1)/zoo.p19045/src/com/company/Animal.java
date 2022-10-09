package com.company;

import java.io.FileInputStream;
import java.io.ObjectInputStream;
import java.io.Serializable;
import java.util.List;
import java.util.Scanner;

public class Animal implements Serializable {
    //private metavlites ya prostasia dedomenwn
    private String cod;
    private String name;
    private String omot;
    private String weight;
    private String age;
    //getter and setter
    public String getCod() { //pairnw timi
        return cod;
    }

    public void setCod(String cod) { //dinw timi
        if (cod.isBlank() || elegxos(cod)){ //kalume tin sinartisi elegxo
            System.out.println("Δώστε σωστή τιμή!"+"\n..."+"\n");
            Scanner scanner= new Scanner(System.in);
            String input = scanner.nextLine();
            setCod(input);
        }else{
            this.cod = cod;
        }
    }

    public String getName() { //pairnw timi
        return name;
    }

        public void setName(String name) { //dinw timi
        if (name.isBlank() || name.matches(".*\\d.*")){
            System.out.println("Δώστε σωστή τιμή!");
            Scanner scanner= new Scanner(System.in);
            String input = scanner.nextLine();
            setName(input);

        }else{
        this.name = name;
        }
    }

    public String getOmot() { //pairnw timi
        return omot;
    }

    public void setOmot(String omot) { //dinw timi
        if (omot.isBlank() || omot.matches(".*\\d.*")) {
            System.out.println("Δώστε σωστή τιμή!");
            Scanner scanner = new Scanner(System.in);
            String input = scanner.nextLine();
            setOmot(input);
        }else{
            this.omot = omot;
        }
    }

    public String getWeight() { //pairnw timi
        return weight;
    }

    public void setWeight(String weight) { //dinw timi
        if (weight.isBlank() || weight.matches(".*[a-z].*") || weight.matches(".*[A-Z].*")){
            System.out.println("Δώστε σωστή τιμή!");
            Scanner scanner= new Scanner(System.in);
            String input = scanner.nextLine();
            setWeight(input);
        }else{
            this.weight = weight;
        }

    }

    public String getAge() { //pairnw timi
        return age;
    }

    public void setAge(String age) { // dinw timi
        if (age.isBlank() || age.matches(".*[a-z].*") || age.matches(".*[A-Z].*")){
            System.out.println("Δώστε σωστή τιμή!");
            Scanner scanner= new Scanner(System.in);
            String input = scanner.nextLine();
            setAge(input);
        }else{
            this.age = age;
        }
    }
    final boolean elegxos(String co){ //elegxume ean uparxei allo zwo me idio kodiko
        try {
            FileInputStream fileInputStream = new FileInputStream("zwa.ser");
            ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
            List<Animal> listazwwn =(List<Animal>)objectInputStream.readObject();
            fileInputStream.close();
            objectInputStream.close();
            for (Animal a:listazwwn){
                if (a.getCod().equals(co)){
                    System.out.println("Δεν μπορείτε να εχετε δυο ζωα με ιδιο κωδικο");
                    return true;
                }
            }
        } catch (Exception e) {

        }
        return false;
    }
}
