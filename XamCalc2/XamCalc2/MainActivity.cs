using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using static Android.Views.View;

namespace XamCalc2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnClickListener
    {
        private TextView _txtv1;

        private Button btn_0, btn_00, btn_dot, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9;
        private Button btn_minuse, btn_plus, btn_divide, btn_multi, btn_back, btn_c, btn_equal;

        private decimal temp1, temp2;

        private string mchar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _txtv1 = FindViewById<TextView>(Resource.Id.txtv1);

            btn_0 = FindViewById<Button>(Resource.Id.btn_0);
            btn_0.SetOnClickListener(this);

            btn_1 = FindViewById<Button>(Resource.Id.btn_1);
            btn_1.SetOnClickListener(this);

            btn_2 = FindViewById<Button>(Resource.Id.btn_2);
            btn_2.SetOnClickListener(this);

            btn_3 = FindViewById<Button>(Resource.Id.btn_3);
            btn_3.SetOnClickListener(this);

            btn_4 = FindViewById<Button>(Resource.Id.btn_4);
            btn_4.SetOnClickListener(this);

            btn_5 = FindViewById<Button>(Resource.Id.btn_5);
            btn_5.SetOnClickListener(this);

            btn_6 = FindViewById<Button>(Resource.Id.btn_6);
            btn_6.SetOnClickListener(this);

            btn_7 = FindViewById<Button>(Resource.Id.btn_7);
            btn_7.SetOnClickListener(this);

            btn_8 = FindViewById<Button>(Resource.Id.btn_8);
            btn_8.SetOnClickListener(this);

            btn_9 = FindViewById<Button>(Resource.Id.btn_9);
            btn_9.SetOnClickListener(this);

            btn_00 = FindViewById<Button>(Resource.Id.btn_00);
            btn_00.SetOnClickListener(this);

            btn_dot = FindViewById<Button>(Resource.Id.btn_dot);
            btn_dot.SetOnClickListener(this);


            btn_plus = FindViewById<Button>(Resource.Id.btn_plus);
            btn_0.SetOnClickListener(this);

            btn_minuse = FindViewById<Button>(Resource.Id.btn_minuse);
            btn_minuse.SetOnClickListener(this);

            btn_divide = FindViewById<Button>(Resource.Id.btn_divide);
            btn_divide.SetOnClickListener(this);

            btn_multi = FindViewById<Button>(Resource.Id.btn_multi);
            btn_multi.SetOnClickListener(this);

            btn_back = FindViewById<Button>(Resource.Id.btn_back);
            btn_back.SetOnClickListener(this);

            btn_c = FindViewById<Button>(Resource.Id.btn_c);
            btn_c.SetOnClickListener(this);

            btn_equal = FindViewById<Button>(Resource.Id.btn_equal);
            btn_equal.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.btn_0)
            {
                _txtv1.Text = _txtv1.Text + btn_0.Text;
            }

            if (v.Id == Resource.Id.btn_1)
            {
                _txtv1.Text = _txtv1.Text + btn_1.Text;
            }

            if (v.Id == Resource.Id.btn_2)
            {
                _txtv1.Text = _txtv1.Text + btn_2.Text;
            }

            if (v.Id == Resource.Id.btn_3)
            {
                _txtv1.Text = _txtv1.Text + btn_3.Text;
            }

            if (v.Id == Resource.Id.btn_4)
            {
                _txtv1.Text = _txtv1.Text + btn_4.Text;
            }

            if (v.Id == Resource.Id.btn_5)
            {
                _txtv1.Text = _txtv1.Text + btn_5.Text;
            }

            if (v.Id == Resource.Id.btn_6)
            {
                _txtv1.Text = _txtv1.Text + btn_6.Text;
            }

            if (v.Id == Resource.Id.btn_7)
            {
                _txtv1.Text = _txtv1.Text + btn_7.Text;
            }

            if (v.Id == Resource.Id.btn_8)
            {
                _txtv1.Text = _txtv1.Text + btn_8.Text;
            }

            if (v.Id == Resource.Id.btn_9)
            {
                _txtv1.Text = _txtv1.Text + btn_9.Text;
            }

            if (v.Id == Resource.Id.btn_00)
            {
                _txtv1.Text = _txtv1.Text + btn_00.Text;
            }

            if (v.Id == Resource.Id.btn_dot)
            {
                _txtv1.Text = _txtv1.Text + btn_dot.Text;
            }

            //Operations : 

            if (v.Id == Resource.Id.btn_plus)
            {
                mchar = "+";
                temp1 = Convert.ToDecimal(_txtv1.Text);
                _txtv1.Text = "";
            }

            if (v.Id == Resource.Id.btn_minuse)
            {
                mchar = "-";
                temp1 = Convert.ToDecimal(_txtv1.Text);
                _txtv1.Text = "";
            }

            if (v.Id == Resource.Id.btn_multi)
            {
                mchar = "*";
                temp1 = Convert.ToDecimal(_txtv1.Text);
                _txtv1.Text = "";
            }

            if (v.Id == Resource.Id.btn_divide)
            {
                mchar = "/";
                temp1 = Convert.ToDecimal(_txtv1.Text);
                _txtv1.Text = "";
            }

            if (v.Id == Resource.Id.btn_equal)
            {
                temp2 = Convert.ToDecimal(_txtv1.Text);
                if (mchar == "+")
                {
                    _txtv1.Text = (temp1 + temp2).ToString();
                }
                if (mchar == "-")
                {
                    _txtv1.Text = (temp1 - temp2).ToString();
                }
                if (mchar == "*")
                {
                    _txtv1.Text = (temp1 * temp2).ToString();
                }
                if (mchar == "/")
                {
                    _txtv1.Text = (temp1 / temp2).ToString();
                }

                //_txtv1.Text = "";
            }

            if (v.Id == Resource.Id.btn_c)
            {
                temp1 = 0;
                temp2 = 0;
                mchar = "";
                _txtv1.Text = "";
            }
        }
    }
}