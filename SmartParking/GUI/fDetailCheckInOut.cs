﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParking.Model
{
    public partial class fDetailCheckInOut : MetroFramework.Forms.MetroForm
    {
        public fDetailCheckInOut()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var List = HandleDataDB.Ins.GetListCheckInOut();
            Grid_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (var item in List)
            {
                Grid_Users.Rows.Add(item.CardID, item.LicensePlate, item.SpaceName, item.CheckInTime, item.CheckOUTTime, item.TotalCost, item.Status);
            }
            
        }
    }
}
