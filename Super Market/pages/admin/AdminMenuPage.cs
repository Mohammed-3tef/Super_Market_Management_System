﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Super_Market.pages.admin;

namespace Super_Market.pages
{
    public partial class AdminMenuPage : Form
    {
        private MainWindow mainWindow;
        public AdminMenuPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.welcomePersonMsg.Text = "Welcome, " + this.mainWindow.user.GetUsername();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(this.mainWindow);
            productManagement.Show();
            this.Close();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UserManagement customerManagement = new UserManagement(this.mainWindow);
            customerManagement.Show();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) return;

            this.mainWindow.Show();
            this.Close();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(this.mainWindow);
            categoryManagement.Show();
            this.Close();
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            DepartmentManagement departmentManagment = new DepartmentManagement(this.mainWindow);
            departmentManagment.Show();
            this.Close();
        }

        private void companyBtn_Click(object sender, EventArgs e)
        {
            CompanyManagement companyManagement = new CompanyManagement(this.mainWindow);
            companyManagement.Show();
            this.Close();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AnalysisDashboard analysisDashboard = new AnalysisDashboard(this.mainWindow);
            analysisDashboard.Show();
            this.Close();
        }
    }
}
