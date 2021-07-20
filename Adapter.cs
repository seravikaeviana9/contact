using Android.Content;
using Android.Views;
using Android.Widget;

namespace TUGAS5_D_672018025
{
    class IniAdapter : BaseAdapter
    {
        private string[] addname;
        private string[] addphone;
        private string[] addemail;
        private string[] gender;
        private string[] addnote;
        private int[] image;
        private Context c;
        LayoutInflater inflater;

        public IniAdapter(Context c, string[] addname, string[] addphone, string[] addemail, string[] gender, string[] addnote, int[] image)
        {
            this.c = c;
            this.addname = addname;
            this.addphone = addphone;
            this.addemail = addemail;
            this.gender = gender;
            this.addnote = addnote;
            this.image = image;
        }

        public override int Count
        {
            get
            {
                return this.addname.Length;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int vw, View convertView, ViewGroup parent)
        {
            if (inflater == null)
            {
                inflater = (LayoutInflater)c.GetSystemService(Context.LayoutInflaterService);
            }
            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Contact, null);
            }

            ImageView img = (ImageView)convertView.FindViewById(Resource.Id.Image);
            TextView txt = (TextView)convertView.FindViewById(Resource.Id.name);
            TextView txt1 = (TextView)convertView.FindViewById(Resource.Id.phone);
            TextView txt2 = (TextView)convertView.FindViewById(Resource.Id.email);
            TextView txt3 = (TextView)convertView.FindViewById(Resource.Id.gender);
            TextView txt4 = (TextView)convertView.FindViewById(Resource.Id.note);

            txt.SetText(addname[vw], null);
            txt1.SetText(addphone[vw], null);
            txt2.SetText(addemail[vw], null);
            txt3.SetText(gender[vw], null);
            txt4.SetText(addnote[vw], null);
            img.SetImageResource(image[vw]);
            return convertView;
        }
    }
}