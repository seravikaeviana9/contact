using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.IO;
using SQLite;
using Android.Content;

namespace TUGAS5_D_672018025
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btn;
        private GridView grd;
        IniAdapter ia;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            grd = (GridView)FindViewById(Resource.Id.grd);
            btn = (Button)FindViewById(Resource.Id.btn);

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
            var db = new SQLiteConnection(dbPath);
            createDB();
            var stockList = db.Table<Data>();

            string[] name = new string[stockList.Count()];
            string[] phone = new string[stockList.Count()];
            string[] email = new string[stockList.Count()];
            string[] gender = new string[stockList.Count()];
            string[] note = new string[stockList.Count()];
            int[] image = new int[stockList.Count()];

            int i = 0;
            foreach (var s in stockList)
            {
                name[i] = s.Name;
                phone[i] = s.Phone;
                email[i] = s.Email;
                gender[i] = s.Gender;
                note[i] = s.Note;
                image[i] = s.Image;

                i++;
            }

            ia = new IniAdapter(this, name, phone, email, gender, note, image);
            grd.SetAdapter(ia);

            btn.Click += delegate
            {
                Intent i = new Intent(this, typeof(Add));
                StartActivity(i);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions,
            [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public string createDB()
        {
            var output = "";
            output += "Creating Database if doesn't exist";
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Data>();
            return "";
        }
    }
}