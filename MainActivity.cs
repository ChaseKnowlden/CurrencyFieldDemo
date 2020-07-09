using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using IO.Sulek.Currencyfield;

namespace CurrencyFieldDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        CurrencyField currencyField;
        Button btnGetValue;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            currencyField = FindViewById<CurrencyField>(Resource.Id.text_field);
            btnGetValue = FindViewById<Button>(Resource.Id.btn_get_value);
            btnGetValue.Click += delegate
            {
                Toast.MakeText(this, "" + currencyField.Value, ToastLength.Long).Show();
            };
        }
	}
}
