using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using SQLite;
using System;
using System.IO;

namespace TUGAS5_D_672018025
{
    [Activity(Label = "Activity1")]
    public class Add : Activity
    {
        private EditText addname, addphone, addemail, addnote;
        private Button addcontact;
        string gndr = "";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Add);

            addname = (EditText)FindViewById(Resource.Id.addname);
            addphone = (EditText)FindViewById(Resource.Id.addphone);
            addemail = (EditText)FindViewById(Resource.Id.addemail);
            //gender = (EditText)FindViewById(Resource.Id.gender);
            RadioGroup radiogrup = (RadioGroup)FindViewById(Resource.Id.radiogender);
            RadioButton radiomale = FindViewById<RadioButton>(Resource.Id.radiomale);
            RadioButton radiofemale = FindViewById<RadioButton>(Resource.Id.radiofemale);
            addnote = (EditText)FindViewById(Resource.Id.addnote);
            addcontact = (Button)FindViewById(Resource.Id.addcontact);

            int idGender = radiogrup.CheckedRadioButtonId;
            int image;
            RadioButton gdr = (RadioButton)FindViewById(idGender);

            radiomale.Click += RadioButtonClick;
            radiofemale.Click += RadioButtonClick;

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
            var db = new SQLiteConnection(dbPath);

            addcontact.Click += delegate
            {
                if (gndr.Equals("Male"))
                {
                    image = Resource.Drawable.male;
                }
                else
                {
                    image = Resource.Drawable.female;
                }
                Data d = new Data();
                d.Name = addname.Text;
                d.Phone = addphone.Text;
                d.Email = addemail.Text;
                d.Gender = gndr;
                d.Note = addnote.Text;
                d.Image = image;

                db.Insert(d);

                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);
                Finish();
            };


            // Create your application here
        }
        private void RadioButtonClick(object obj, EventArgs e)
        {
            RadioButton radioBt = (RadioButton)obj;
            gndr = radioBt.Text;
        }
    }
}