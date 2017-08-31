using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace autoReportInput
{
    public partial class Form1 : Form
    {
        bool time_flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        //表示文字更新
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = textBox1.Text + "秒後、入力開始";
        }

        //入力開始ボタンクリック
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //初期化
            time_flag = false;

            //未入力検出
            if ((textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "") || 
                checkBox1.Checked == true && textBox4.Text == "" ||
                checkBox2.Checked == true && textBox5.Text == "")
            {
                MessageBox.Show("未入力項目があります");
                return;
            }

            //時間検出
            //if (textBox3.Text.IndexOf(":") != -1 || textBox3.Text.IndexOf("：") != -1)
            //{
            //    //5文字かつ真ん中にコロンでなければ不正
            //    if (textBox3.Text.Length != 5 || (textBox3.Text.Substring(2, 1) != ":" && textBox3.Text.Substring(2, 1) != "："))
            //    {
            //        MessageBox.Show("値が不正です");
            //        return;
            //    }

            //    int hour_s,time_s;
            //    hour_s = int.Parse(textBox3.Text.Substring(0,2));
            //    time_s = int.Parse(textBox3.Text.Substring(3,2));

            //    //コロンの左右が0<x<60でなければ不正
            //    if (hour_s < 0 || hour_s > 60 || time_s < 0 || time_s > 60)
            //    {
            //        MessageBox.Show("値が不正です");
            //        return;
            //    }

            //    time_flag = true;
            //}

            double intnum=0;
            int unt1=0,unt2=0;
            string st="";

            //指定時間待ち
            System.Threading.Thread.Sleep(int.Parse(textBox1.Text) * 1000);

            //繰り返し入力処理開始
            if (checkBox1.Checked == true)
            {
                //減算あり時処理
                if (checkBox2.Checked == true)
                {
                    //時間減算処理
                    for (int num = 0; num < int.Parse(textBox2.Text); num++)
                    {
                        unt1=int.Parse(textBox3.Text);
                        unt2=int.Parse(textBox5.Text) - (num*int.Parse(textBox4.Text));

                        if (unt2 < 0)
                        {
                            unt1 = unt1 - 1;
                            unt2 = 60 + unt2;
                        }

                        st = unt1.ToString() + ":" + unt2.ToString();
                        SendKeys.Send(st);
                        SendKeys.Send("{ENTER}");
                    }
                }
                else
                {
                    //時間以外の減算処理
                    for (int num = 0; num < int.Parse(textBox2.Text); num++)
                    {
                        intnum = double.Parse(textBox3.Text) - (num * double.Parse(textBox4.Text));
                        st = intnum.ToString();
                        SendKeys.Send(st);
                        SendKeys.Send("{ENTER}");
                    }
                }
            }
            else
            {
                //減算なし時処理
                for (int num = 0; num < int.Parse(textBox2.Text); num++)
                {
                    SendKeys.Send(textBox3.Text);
                    SendKeys.Send("{ENTER}");
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //減算チェック
            textBox4.Enabled = !textBox4.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //運転時間チェック
            textBox5.Enabled = !textBox5.Enabled;
        }
    }
}
