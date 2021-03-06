﻿using System;
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
    public partial class A3zone : Form
    {
        public A3zone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //ปิดการทำงาน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tt = totaltik.Text; //กำหนดตัวแปรที่ต้องการ
            int tik; //กำหนดค่าตัวแปรของตัวเลข
            int.TryParse(tt, out tik); //เช็คว่าข้อมูลที่กรอกนั้นเป็นคัวเลขที่ต้องการหรือไม่
            if (totaltik.Text == string.Empty) //ถ้าช่องใส่จำนวนตั๋วว่าง
            {
                checktikfall(); //ตรวจสอบข้อมูล
            }
            else if (tik > 6)
            {
                MessageBox.Show("เลือกจำนวนไม่ถูกต้อง กรุณาเลือกใหม่", //แสดงข้อความตรงกลางของ MessageBox
                                    "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                                    MessageBoxButtons.OK, //ปุ่มกดการทำรายการ
                                    MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox);
            }
            else
            {
                checktik(); //ตรวจสอบข้อมูล
            }
        }
        void checktik()
        {
            {
                MessageBox.Show("ยืนยันการเลือกที่นั่ง", //แสดงข้อความตรงกลางของ MessageBox
                             "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                            MessageBoxButtons.OKCancel, //ปุ่มกดการทำรายการ
                            MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox
                MessageBox.Show("เลือกที่นั่งเรียบร้อยแล้ว", //แสดงข้อความตรงกลางของ MessageBox
                                    "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                                    MessageBoxButtons.OK, //ปุ่มกดการทำรายการ
                                    MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void totaltik_TextChanged(object sender, EventArgs e)
        {
            string tt = totaltik.Text; //กำหนดตัวแปรที่ต้องการ
            int tik; //กำหนดค่าตัวแปรของตัวเลข
            int.TryParse(tt, out tik); //เช็คว่าข้อมูลที่กรอกนั้นเป็นคัวเลขที่ต้องการหรือไม่
            int sum = 4500 * tik; //คำนวณราคาบัตรและราคา
            if (tik == 1) //ถ้าเลือก1ใบ
            {
                sum = 4500 * tik; //คำนวณราคาบัตรและราคา
                total_buy.Text = sum.ToString(); //รวมจำนวนและราคาทั้งหมดที่คำนวณจากสูตรที่ตั้งจะแสดงผลที่ total_buy (ผลลัพธ์)
            }
            else if (tik >= 1 && tik <= 6) //ถ้าเลือกตั้งแต่สองใบขึ้นไป
            {
                sum = 4500 * tik; //คำนวณราคาบัตรและราคา
                total_buy.Text = sum.ToString(); //รวมจำนวนและราคาทั้งหมดที่คำนวณจากสูตรที่ตั้งจะแสดงผลที่ total_buy (ผลลัพธ์)
            }
        }
        void checktikfall()
        {
            MessageBox.Show("ยังไม่ทำรายการ กรุณาทำรายการใหม่", //แสดงข้อความตรงกลางของ MessageBox
                            "ยืนยัน", //แสดงข้อความตรงแท็บของ MessageBox
                            MessageBoxButtons.OK, //ปุ่มกดการทำรายการ
                            MessageBoxIcon.Question); //แสดงไอคอนตรงกลาง MessageBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totaltik.Clear();
            total_buy.Text = "";
        }
    }
}
