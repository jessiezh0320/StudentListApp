using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace StudentListApp
{
   public class Student
    {
        public int Code, Age, Image;
        public string Nom, Prenom, Adresse, Infos, Classe;

        public Student(int code, string nom, string prenom, int age, string adresse, string infos, int image, string classe)
        {
            this.Code = code;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Adresse = adresse;
            this.Infos = infos;
            this.Image = image;
            this.Classe = classe;
        }
    }
}