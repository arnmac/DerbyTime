﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DerbyTime
{
    public partial class DriversScreen : Form
    {
        public List<Racer> Drivers = new List<Racer>();

        public DriversScreen()
        {
            InitializeComponent();
            Drivers.Add(new Racer(Den.Bear, ""));
            Drivers.Add(new Racer(Den.Bear, ""));
            Drivers.Add(new Racer(Den.Bear, ""));
        }
    }
}
