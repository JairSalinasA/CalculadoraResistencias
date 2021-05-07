using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistence.Forms
{
    public partial class CodeColors : Form
    {
        public CodeColors()
        {
            InitializeComponent();
            
        }

        private void CodeColors_Load(object sender, EventArgs e)
        {
            fillHeadersGridView();
            fillCellGridView();
            themeColorGridView();
        }


        public void fillHeadersGridView()
        {
            
            colorGridView.Columns.Add("color", "Color");
            colorGridView.Columns.Add("1a Banda", "1a Banda");
            colorGridView.Columns.Add("2a Banda", "2a Banda");
            colorGridView.Columns.Add("3a Banda", "3a Banda");
            colorGridView.Columns.Add("multiplicador", "Multiplicador");
            colorGridView.Columns.Add("tolerancia", "Tolerancia");
            colorGridView.Columns.Add("tem", "Coeficiente de Temp.");
        }
        
        public void fillCellGridView()
        {
            string[] row = new string[] { "Negro", "0", "0", "0", "1Ω", "-", "-" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Marrón", "1", "1", "1", "10Ω", "±1%", "100 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Rojo", "2", "2", "2", "100Ω", "±2%", "50 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Naranja", "3", "3", "3", "1000Ω", "-", "15 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Amarillo", "4", "4", "4", "10000Ω", "-", "25 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Verde", "5", "5", "5", "100000Ω", "±0,5%", "-" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Azul", "6", "6", "6", "1000000Ω", "±0,25%", "10 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Violeta", "7", "7", "7", "10000000Ω", "±0,10%", "5 ppm/ºC" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Gris", "8", "8", "8", "100000000Ω", "±0,05%", "-" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Blanco", "9", "9", "9", "1000000000Ω", "-", "-" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Oro", "-", "-", "-", "0,1Ω", "±5%", "-" };
            colorGridView.Rows.Add(row);
            row = new string[] { "Plata", "-", "-", "-", "0,01Ω", "±10%", "-" };
            colorGridView.Rows.Add(row);
        }

        public void themeColorGridView()
        {
            colorGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 128, 236);
            
            colorGridView.EnableHeadersVisualStyles = false;
            colorGridView.Rows[0].DefaultCellStyle.BackColor = Color.Black;
            colorGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
            colorGridView.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(153, 51, 0);
            colorGridView.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(204, 51, 0);
            colorGridView.Rows[3].DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 0);
            colorGridView.Rows[4].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 0);
            colorGridView.Rows[5].DefaultCellStyle.BackColor = Color.FromArgb(0, 204, 0);
            colorGridView.Rows[6].DefaultCellStyle.BackColor = Color.FromArgb(0, 51, 204);
            colorGridView.Rows[7].DefaultCellStyle.BackColor = Color.FromArgb(153, 51, 153);
            colorGridView.Rows[8].DefaultCellStyle.BackColor = Color.FromArgb(153, 153, 153);
            colorGridView.Rows[9].DefaultCellStyle.BackColor = Color.White;
            colorGridView.Rows[10].DefaultCellStyle.BackColor = Color.Gold;
            colorGridView.Rows[11].DefaultCellStyle.BackColor = Color.Silver;
        }
    }
}
