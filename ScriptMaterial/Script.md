Anda bisa membuat file c# baru dengan :
```
1. mengklik kanan di panel Asset (biasanya di bagian bawah)
2. Lalu Create > C# Script
3. Lalu anda akan diminta memberi nama file
4. Gunakan Huruf awal besar untuk setiap kata dan hindari penggunaan spasi
Contoh : GameManager, PlayerController, Point
```

Berikut contoh C# script yang baru dibuat
```
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
```

```
/********************************************************************/
Seperti pada bahasa lainnya, C# memiliki 4 variabel dasar, yaitu :
       string      untuk kalimat
       int         untuk bilangan bulat
       float       untuk bilangan koma
       bool        untuk true / false

/********************************************************************/
Cara mendeklarasikan variabel adalah sebagai berikut
    public int angka1;     <------ public variabel
    [SerializedField]      <------ Untuk menampilkan pada game engine
    private int angka2;    <------ private variabel
           int angka3;     <------ private variabel
    ^       ^     ^
    |       |     nama variabel
    |       tipe variabel
    jangkauan variabel

    > jangkauan Variabel terdiri atas public dan private
        > Dimana public berarti variabel tersebut bisa dipanggil dari dalam script itu sendiri
          atau dari script lain
        > public dan [SerializedField] akan membuat variabel dapat diedit di panel inspector
          (biasanya sebelah kanan) pada unity
        > private variabel berarti variabel yang hanya bisa dipanggil di dalam script itu sendiri,
          caranya dengan menulis 'private' sebelum tipe variabel atau tidak menulis apapun sebelum
          tipe variabel
        > Nama variabel bisa apa saja, disarankan menggunakan huruf kecil diawal kata dan awalan 
          huruf besar untuk kata selanjutnya atau menggunakan _ untuk mengganti spasi
          Contoh : tinggiBadan, berat_Badan
        > Dilarang menggunkan angka untuk awalan atau hanya angka untuk nama variabel
          Contoh : 1angka, 2buah, 523

