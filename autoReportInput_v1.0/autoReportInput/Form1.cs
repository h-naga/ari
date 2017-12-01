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
        //bool time_flag = false;

        //////////////////////////////////////////////////////////////////////////////
        //表示更新処理
        //////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
        }

        //ラジオボタン初期値を設定
        private void Form1_Load(object sender, EventArgs e)
        {
            numberRadioButton.Checked = true;
        }

        //表示文字更新
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = secondSettingText.Text + "秒後、入力開始";
        }



        //////////////////////////////////////////////////////////////////////////////
        //入力処理
        //////////////////////////////////////////////////////////////////////////////

        //入力開始ボタンクリック
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //選択されたラジオボタンを取得
            var RadioButtonChecked = inputFormatGroupBox.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            //未入力検出

            //秒数確認
            if (secondSettingText.Text == "")
            {
                MessageBox.Show("未入力項目があります");
                return;
            }

            switch (RadioButtonChecked.Text)
            {
                case "数値":
                    if (countSettingText.Text == "" ||
                        numberText.Text == "" ||
                        (substractionCheckbox.Checked == true && substractionSettingText.Text == ""))
                    {
                        MessageBox.Show("未入力項目があります");
                        return;
                    }
                    break;
                case "運転時間":
                    if (countSettingText.Text == "" ||
                        drivingTimeText1.Text == "" ||
                        drivingTimeText2.Text == "" ||
                        (substractionCheckbox.Checked == true && substractionSettingText.Text == ""))
                    {
                        MessageBox.Show("未入力項目があります");
                        return;
                    }
                    break;
                case "文字列":
                    if (countSettingText.Text == "" ||
                        stringText.Text == "")
                    {
                        MessageBox.Show("未入力項目があります");
                        return;
                    }
                    break;
                case "複数行テキスト":
                    if (mulchStringText.Text == "")
                    {
                        MessageBox.Show("未入力項目があります");
                        return;
                    }
                    break;
            }

            //指定時間待ち
            System.Threading.Thread.Sleep(int.Parse(secondSettingText.Text) * 1000);

            //初期化
            double intnum = 0;
            int unt1 = 0, unt2 = 0, unt3 = 0;
            string st = "";

            //反復入力処理
            switch (RadioButtonChecked.Text)
            {
                case "数値":
                    //①数値処理
                    if (substractionCheckbox.Checked == true)
                    {
                        //①-1数値処理（減算あり）
                        try
                        {
                            double.Parse(numberText.Text);
                        }
                        catch
                        {
                            MessageBox.Show("入力値が不正です");
                            return;
                        }

                        try
                        {
                            double.Parse(substractionSettingText.Text);
                        }
                        catch
                        {
                            MessageBox.Show("入力値が不正です");
                            return;
                        }

                        
                        for (int num = 0; num < int.Parse(countSettingText.Text); num++)
                        {
                            intnum = double.Parse(numberText.Text) - (num * double.Parse(substractionSettingText.Text));
                            st = intnum.ToString();
                            SendKeys.Send(st);
                            SendKeys.Send("{ENTER}");
                        }
                    }
                    else
                    {
                        //①-2数値処理（減算なし）
                        for (int num = 0; num < int.Parse(countSettingText.Text); num++)
                        {
                            SendKeys.Send(numberText.Text);
                            SendKeys.Send("{ENTER}");
                        }
                    }

                    break;

                case "運転時間":
                    //②運転時間処理
                    if (substractionCheckbox.Checked == true)
                    {
                        //②-1運転時間処理（減算あり）
                        if (int.Parse(drivingTimeText2.Text) > 59)
                        {
                            MessageBox.Show("入力値が不正です");
                            return;
                        }
                       
                        try
                        {
                            int.Parse(substractionSettingText.Text);
                        }
                        catch
                        {
                            MessageBox.Show("入力値が不正です");
                            return;
                        }

                        for (int num = 0; num < int.Parse(countSettingText.Text); num++)
                        {
                            unt1 = int.Parse(drivingTimeText1.Text);
                            unt2 = int.Parse(drivingTimeText2.Text);

                            //分換算して引き算
                            unt3 = unt1 * 60 + unt2;
                            unt3 = unt3 - (num * int.Parse(substractionSettingText.Text));

                            //時分換算
                            unt1 = unt3 / 60;
                            unt2 = unt3 % 60;

                            st = unt1.ToString() + ":" + unt2.ToString();
                            SendKeys.Send(st);
                            SendKeys.Send("{ENTER}");
                        }
                    }
                    else
                    {
                        //②-2運転時間処理（減算なし）
                        for (int num = 0; num < int.Parse(countSettingText.Text); num++)
                        {
                            SendKeys.Send(drivingTimeText1.Text + ":" + drivingTimeText2.Text);
                            SendKeys.Send("{ENTER}");
                        }
                    }

                    break;

                case "文字列":
                    //③文字列処理
                    for (int num = 0; num < int.Parse(countSettingText.Text); num++)
                    {
                        SendKeys.Send(stringText.Text);
                        SendKeys.Send("{ENTER}");
                    }
                    break;

                case "複数行テキスト":
                    //④複数行テキスト処理
                    for (int num = 0; num < mulchStringText.Lines.Length; num++)
                    {
                        SendKeys.Send(mulchStringText.Lines[num]);
                        SendKeys.Send("{ENTER}");
                    }
                    break;

                default:
                    
                    break;
            }
        }


        //////////////////////////////////////////////////////////////////////////////
        //チェック処理
        //////////////////////////////////////////////////////////////////////////////

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void number_point_hifun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void substractionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //減算チェック
            substractionSettingText.Enabled = !substractionSettingText.Enabled;
        }

        private void numberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //数値文字列チェック
            numberText.Enabled = !numberText.Enabled;
        }

        private void drivingTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //運転時間チェック
            drivingTimeText2.Enabled = !drivingTimeText2.Enabled;
            drivingTimeText1.Enabled = !drivingTimeText1.Enabled;
        }

        private void stringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //文字列チェック
            stringText.Enabled = !stringText.Enabled;
            substractionCheckbox.Enabled = !substractionCheckbox.Enabled;
            substractionSettingText.Enabled = !substractionSettingText.Enabled;
        }

        private void mulchStringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //複数行チェック
            mulchStringText.Enabled = !mulchStringText.Enabled;
            countSettingText.Enabled = !countSettingText.Enabled;
            substractionCheckbox.Enabled = !substractionCheckbox.Enabled;
            substractionSettingText.Enabled = !substractionSettingText.Enabled;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //クリアボタン
            mulchStringText.Text = "";
        }
    }
}
