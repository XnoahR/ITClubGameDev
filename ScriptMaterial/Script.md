//Anda bisa membuat file c# baru dengan mengklik kanan di panel Asset (biasanya di bagian bawah)
//Lalu Create > C# Script
//Lalu anda akan diminta memberi nama file
//Gunakan Huruf awal besar untuk setiap kata dan hindari penggunaan spasi
//Contoh : GameManager, PlayerController, Point


//Berikut contoh C# script yang baru dibuat
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamaScript : MonoBehaviour
{
  void Start(){ //Function yang akan dipanggil sekali di awal
   
  }
  
  void Update(){ //Function yang dipanggil sekali tiap frame
  
  }
}

/********************************************************************/
//Seperti pada bahasa lainnya, C# memiliki 4 variabel dasar, yaitu :
//        string      untuk kalimat
//        int         untuk bilangan bulat
//        float       untuk bilangan koma
//        bool        untuk true / false

/********************************************************************/
//Cara mendeklarasikan variabel adalah sebagai berikut
//    public int angka1;     <------ public variabel
//    private int angka2;    <------ private variabel
//           int angka3;     <------ private variabel
//    ^       ^     ^
//    |       |     nama variabel
//    |       tipe variabel
//    jangkauan variabel
//
//    > jangkauan Variabel terdiri atas public dan private
//        > Dimana public berarti variabel tersebut bisa dipanggil dari dalam script itu sendiri
//          atau dari script lain
