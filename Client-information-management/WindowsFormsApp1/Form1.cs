using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*************************************************************************************
        //画面移動用のDLL
        //*************************************************************************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);


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
        //*************************************************************************************
        //最大化解除ボタンクリック
        //*************************************************************************************
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }
        //*************************************************************************************
        //最小化ボタンクリック
        //*************************************************************************************
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //*************************************************************************************
        //マウス操作から画面が動かせるようにする
        //*************************************************************************************
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
