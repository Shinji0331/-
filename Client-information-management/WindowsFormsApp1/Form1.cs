using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //*************************************************************************************
        //メニューボタンクリック
        //*************************************************************************************
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250){
                //サイドバー幅が250の際は70に変更
                MenuVertical.Width = 70;
            }
            else
                //上記以外の際は70に変更
                MenuVertical.Width = 250;
        }

        //*************************************************************************************
        //クローズボタンクリック
        //*************************************************************************************
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //*************************************************************************************
        //最大化ボタンクリック
        //*************************************************************************************
        private void iconmaxizar_Click(object sender, EventArgs e)
        {
            //フォームを最大化
            this.WindowState = FormWindowState.Maximized;

            //重複ボタンを表示
            iconrestaurar.Visible = true;

            //最大化ボタンを非表示
            iconmaximizar.Visible = false;
        }


    }
}
