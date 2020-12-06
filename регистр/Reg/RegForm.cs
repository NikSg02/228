using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reg
{
    public partial class RegForm : Form
    {
        RegistrationForm registrationForm = new RegistrationForm();

        public RegForm()
        {
            InitializeComponent();

            registrationForm.ShowDialog(); // Отображаем форму авторизации.

            nameLabel.Text = "Здравствуйте, " + registrationForm.login + "!";
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
