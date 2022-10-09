package com.company;
import java.io.*;
import java.nio.channels.FileLock;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
public class Main {
    public void myMethod() {
        // menu kai elegxos epiloghs apo ton xrhsth
        System.out.print("\n"+"Εφαρμογή Zoo \n" +
                "Παρακαλώ επιλέξτε από το παρακάτω menu επιλογών \n" +
                "---------------------------------------------- \n" +
                "1. Προβολή όλων των διαθέσιμων ζώων του ζωολογικού κήπου \n" +
                "2. Προσθήκη νέου ζώου \n" +
                "3. Αναζήτηση ζώου βάσει ονόματος \n" +
                "4. Αναζήτηση ζώου βάσει κωδικού \n" +
                "5. Επεξεργασία ζώου βάσει κωδικού \n" +
                "6.Διαγραφή ζώου βάσει κωδικού \n" +
                "7.Έξοδος από την εφαρμογή\n");
        Scanner s1 = new Scanner(System.in);//scanner
        String apadisi = s1.next(); //eisagwgh timis apo to xristi
        System.out.println("Επιλέξατε το νούμερο: " + apadisi); //minima pros ton xrisi
        //EMFANISI ZWWN!
        if (Integer.parseInt(apadisi) == 1) {
            Zoo zoo = new Zoo();
            zoo.mini();
            // provoli diathesimwn zwwn tu kipou, dld oti exei apothikeftei sto file
            try {
                //anigma arxeiou k pernume t dedomena tis listas
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
                List<Animal> listazwwn =(List<Animal>)objectInputStream.readObject(); //dimiurgia lista tipu Animal me onoma listazwwn k apothikevume stin lista ta dedomena tu arxiou
                //klinume arxeio
                fileInputStream.close();
                objectInputStream.close();
                for (Animal a:listazwwn){
                    System.out.println("κωδικός: "+a.getCod()+" ονομα: "+a.getName()+" ομοταξία: "+ a.getOmot()+" βάρος :"+a.getWeight()+" ηλικια: "+a.getAge());
                }
            } catch (Exception e) {

            }
            // PROSTHIKI ZWOU!
        } else if (Integer.parseInt(apadisi) == 2) {
            //prosthetei neo zwo, zitontas ta "stixia" tu apo ton xrhsth
            Animal animal= new Animal(); //dimiurgia objecy
            Scanner scanner= new Scanner(System.in); //scanner
            System.out.println("Δώσε κωδικό"); //minima pros ton xristi
            String incod = scanner.nextLine(); // eisagwgh timis apo ton xristi
            animal.setCod(incod);
            System.out.println("Δώσε ηλικία"); //minima pros ton xristi
            String inage = scanner.nextLine(); // eisagwgh timis apo ton xristi
            animal.setAge(inage);
            System.out.println("Δώσε ονομα"); //minima pros ton xristi
            String inname = scanner.nextLine();
            animal.setName(inname);
            System.out.println("Δώσε βάρος"); //minima pros ton xristi
            String inweight = scanner.nextLine();
            animal.setWeight(inweight);
            System.out.println("Δώσε ομοταξία"); //minima pros ton xristi
            String inomot = scanner.nextLine();
            animal.setOmot(inomot);
            List<Animal> listazwwn = new ArrayList<>(); //dimiurgia listas
            try {
                //anigma arxeiou k pernume t dedomena tis listas
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
                listazwwn =(List<Animal>)objectInputStream.readObject(); //casting
                listazwwn.add(animal); //prosthetume to object sto telos tis listas
                //klinume arxeio
                fileInputStream.close();
                objectInputStream.close();
                // anigume arxeio ya na apothikefsume thn lista
                FileOutputStream fileOutputStream = new FileOutputStream("zwa.ser");
                ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
                objectOutputStream.writeObject(listazwwn); //apothikevume thn lista sto arxeio
                //klinume to arxeio
                objectOutputStream.close();
                fileOutputStream.close();

            }
            catch (Exception e){

            }

        // ANAZITISI ZWWN APO ONOMA!
        } else if (Integer.parseInt(apadisi) == 3) {
            //eisagwgh timis apo xrhsth
            Scanner scanner = new Scanner(System.in);
            System.out.println("Γράψτε όνομα ζώου!");
            String input = scanner.nextLine();

            try {
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
                List<Animal> listazwwn =(List<Animal>)objectInputStream.readObject(); // anigume arxeio k pernume lista
                objectInputStream.close();
                fileInputStream.close();
                Animal serObject=null; //dimiurgume object kai dinume timi null
                //elegcume ean to zwo pou psaxnei o xristis uparxei sthn lista
                for (Animal a: listazwwn){
                    if(a.getName().equals(input)){ //efoson uparxi to apothikevume sto object p dimiurgisame
                        serObject=a;
                    }
                }
                // ama den uparxei to zwo sthn lista emfanizume minima ston xristi
                if (serObject==null){
                    System.out.println("Δεν βρέθηκε το ζώο: " +" "+ input );

                }else{
                    //ean uparxei efmanizume ston xristi ta xaraktiristika tu zwou
                    System.out.println("To ζώο που αναζητήσατε βρέθηκε!!!");
                    System.out.print("΄Κωδικός ζώου:        "+serObject.getCod()+"\n"+
                    "Ονομα ζώου:        "+serObject.getName()+"\n"+
                    "Ομοταξία:      "+serObject.getOmot()+"\n"+
                    "Βάρος:     "+ serObject.getWeight()+"\n"+
                    "Ηλικία:        "+serObject.getAge());
                }
            } catch (Exception e) {
                System.out.println("Δεν βρέθηκε ζώο");
            }


        } else if (Integer.parseInt(apadisi) == 4) {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Γράψτε κωδικό ζώου!");
            String input = scanner.nextLine();

            try {
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
                List<Animal> listazwwn =(List<Animal>)objectInputStream.readObject(); // anigume arxeio k pernume lista
                objectInputStream.close();
                fileInputStream.close();
                Animal serObjectCod=null;
                for (Animal a: listazwwn){
                    if(a.getCod().equals(input)){
                        serObjectCod=a;
                    }
                }
                if (serObjectCod==null){
                    System.out.println("Δεν βρέθηκε το ζώο με κωδικό: " +" "+ input );

                }else{
                    System.out.println("To ζώο που αναζητήσατε βρέθηκε!!!");
                    System.out.print("΄Κωδικός ζώου:        "+serObjectCod.getCod()+"\n"+
                            "Ονομα ζώου:        "+serObjectCod.getName()+"\n"+
                            "Ομοταξία:      "+serObjectCod.getOmot()+"\n"+
                            "Βάρος:     "+ serObjectCod.getWeight()+"\n"+
                            "Ηλικία:        "+serObjectCod.getAge());
                }
            } catch (Exception e) {
                System.out.println("Δεν βρέθηκε ζώο");
            }
        }
        //EPEJERGASIA ZWOU VASI KWDIKOU
        else if (Integer.parseInt(apadisi) == 5) {
            try {
                Scanner scanner = new Scanner(System.in);
                System.out.println("Ποιο ζώο θα θέλατε να επεξεργαστείτε;(Γράψτε τον κωδικό του!)");
                String input = scanner.nextLine();
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream (fileInputStream);
                List<Animal> listazwwn =(List<Animal>)objectInputStream.readObject(); // anigma arxiou , pernume lista kai thn apothikevume sto Animal
                objectInputStream.close();
                fileInputStream.close();
                Animal zwo = null;
                //vrisko zwo k pernw ta stixia t k ta apothikevw sto Animal sto object zwo
                for (Animal a: listazwwn) {
                    if (a.getCod().equals(input)) {
                        zwo = a;
                        System.out.println("΄Κωδικός ζώου: "+zwo.getCod()+ "Ονομα ζώου: "+zwo.getName()+"Ομοταξία: "+zwo.getOmot()+ "Βάρος: "+ zwo.getWeight()+ "Ηλικία: "+zwo.getAge());
                        System.out.println("Τι θα θέλατε να αλλάξετε στο ζώο;");
                        System.out.println("ΠΛΗΚΤΡΟΛΟΓΊΣΤΕ: \n 1.Αλλαγή ονόματος \n 2.Αλλαγή κωδικού \n 3. Αλλαγή ομοταξίας \n 4.Αλλαγή βάρους \n 5.Αλλαγή ηλικίας");
                        Scanner scanner1 = new Scanner(System.in);
                        String input1 = scanner1.nextLine();
                        while (true) {
                            try {
                                if (Integer.parseInt(input1) == 1) {
                                    System.out.println("Τι ονομα θα θέλατε να δώσετε στο ζώο;");
                                    input1 = scanner.nextLine();
                                    a.setName(input1);
                                    System.out.println("Αποθηκεύτηκε επιτυχώς");
                                    break;
                                }
                                else if (Integer.parseInt(input1) == 2) {
                                    System.out.println("Τι κωδικο θα θέλατε να δώσετε στο ζώο;");
                                    input1= scanner.nextLine();
                                    a.setCod(input1);
                                    System.out.println("Αποθηκεύτηκε επιτυχώς");
                                    break;
                                }
                                else if (Integer.parseInt(input1) == 3 ){
                                    System.out.println("Τι ομοταξία θα θέλατε να δώσετε στο ζώο;");
                                    input1 = scanner.nextLine();
                                    a.setOmot(input1);
                                    System.out.println("Αποθηκεύτηκε επιτυχώς");
                                    break;
                                }
                                else if (Integer.parseInt(input1) == 4){
                                    System.out.println("Τι βάρος θα θέλατε να δώσετε στο ζώο;");
                                    input1 = scanner.nextLine();
                                    a.setWeight(input1);
                                    System.out.println("Αποθηκεύτηκε επιτυχώς");
                                    break;
                                }else if (Integer.parseInt(input1) == 5){
                                    System.out.println("Τι ηλικία θα θέλατε να δώσετε στο ζώο;");
                                    input1 = scanner.nextLine();
                                    a.setAge(input1);
                                    System.out.println("Αποθηκεύτηκε επιτυχώς");
                                    break;
                                }else{
                                    System.out.println("Δέν επιλεξατε κατι απο τις επιλογες");
                                    input1 = scanner1.nextLine();
                                }
                            }
                            catch (Exception e){
                                System.out.println("H τιμη δεν ειναι εγγυρη!");
                                System.out.println("Δωσε εγγυρη τιμή");
                                System.out.println("Τι θα θέλατε να αλλάξετε στο ζώο;");
                                System.out.println("ΠΛΗΚΤΡΟΛΟΓΊΣΤΕ: \n 1.Αλλαγή ονόματος \n 2.Αλλαγή κωδικού \n 3. Αλλαγή ομοταξίας \n 4.Αλλαγή βάρους \n 5.Αλλαγή ηλικίας");
                                input1 =scanner1.nextLine();

                            }
                        }
                        FileOutputStream fileOutputStream = new FileOutputStream("zwa.ser");
                        ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
                        objectOutputStream.writeObject(listazwwn);
                        objectOutputStream.close();
                        fileOutputStream.close();
                    }
                }
                if (zwo==null){
                    System.out.println("Δεν βρεθηκε ζωο με αυτον τον κωδικο!");
                }
            } catch (Exception e) {
                System.out.println(e);

            }

        }
        //DIAGRAFI ZWOU VASI KWDIKOU
        else if (Integer.parseInt(apadisi) == 6) {
            try {
                Scanner scanner = new Scanner(System.in); //dimiurgia scanner
                System.out.println("Δώσε τον κωδικό του ζώου που θέλετε να διαγραψετε!"); //minima pros ton xristi
                String input = scanner.nextLine(); //pernume timi apo thn xristi me tn voithia tu xristi
                FileInputStream fileInputStream = new FileInputStream("zwa.ser");
                ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
                List<Animal> listazwwn = (List<Animal>) objectInputStream.readObject(); // anigma arxiou , pernume lista kai thn apothikevume sto Animal
                objectInputStream.close();
                fileInputStream.close();
                Animal animal=null;
                for(Animal a:listazwwn){
                    if(a.getCod().equals(input)) {
                        animal=a;
                        listazwwn.remove(a); // svisimo tu zwou apo thn listazwwn
                        FileOutputStream fileOutputStream = new FileOutputStream("zwa.ser");
                        ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
                        objectOutputStream.writeObject(listazwwn); //janagrafume vazume tn lista sto arxeio xwris to zwo pou epeleje o xrhsths
                        objectOutputStream.close();
                        fileOutputStream.close();
                        System.out.println("Αποθηκευτηκε επιτυχως");
                    }
                }
                // elegxos ean vrethike animal pou epsaxne o xristis
                if (animal==null){
                    System.out.println("Δεν βρέθηκε ζωο με αυτον τον κωδικό");
                }else {
                    System.out.println("Διαγράφηκε το ζώο με κωδικο: "+input);
                }
            }
            catch (Exception a){

            }

        }
        //EXIT APO EFARMOGH
        else if (Integer.parseInt(apadisi) == 7) {
            System.out.println("Bye :)"); //minima
            System.exit(0);         // exit apo efarmogh
        } else {
            // ean o xrhsths dwsei "lathos epilogh" stelnw minima kai janatrexw thn methodo apo thn arxh, ara tu zitaw allh "apadisi" pou na uparxei sto menu
            System.out.println("Δεν επιλέξατε κάτι απο το menou!"); // minima lathus
            myMethod(); //jana trexume tn methodo
        }
    }
    public static void main(String[] args) {
        Zoo zoo = new Zoo();
        zoo.myAnimals(); // dimiurgo t zwo m k to pernaw sto file
        Main object = new Main();
        while(true){//h efarmogh trexi mexri na tn klisi o xristis epilegodas tin epilogh 7
        object.myMethod(); // menu kai elegxos epiloghs apo ton xrhsth
        }
    }
}
