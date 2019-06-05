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
    public class gridView_Adapter: BaseAdapter
    {
        List<Student> listStudents;
        Activity a;


        public gridView_Adapter(List<Student> listStudents, Activity a)
        {
            this.a = a;
            this.listStudents = listStudents;
        }
        public override int Count => listStudents.Count;
        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var t = listStudents[position];
            View v = convertView;
            //Creation de la vue
            v = a.LayoutInflater.Inflate(Resource.Layout.activity_image, null);
            Button Fermer = v.FindViewById<Button>(Resource.Id.button1);
            TextView name_tv = v.FindViewById<TextView>(Resource.Id.nametxt);
            name_tv.Text = t.Nom;

            v.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(t.Image);
            return v;
        }
    }
}