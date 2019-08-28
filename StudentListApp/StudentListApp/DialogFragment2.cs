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
    public class DialogFragment2: DialogFragment
    {
            public static DialogFragment2 NewInstance(Bundle bundle)
            {
                DialogFragment2 fragment = new DialogFragment2();
                fragment.Arguments = bundle;
                return fragment;
            }
            public override Dialog OnCreateDialog(Bundle savedInstanceState)
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(Activity);
                alert.SetTitle("Confirm Dialog");
                alert.SetMessage("test...");
                alert.SetCancelable(false);
                
                alert.SetPositiveButton("OK", (senderAlert, args) => {
                    Toast.MakeText(Activity, "Go!", ToastLength.Short).Show();
                });
                alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                    Toast.MakeText(Activity, "Cancelled!", ToastLength.Short).Show();
                });

                AlertDialog alertDialog = alert.Create();
                alertDialog.SetCanceledOnTouchOutside(false);

               return alertDialog;

            //return alert.Create();
            }
    }
}