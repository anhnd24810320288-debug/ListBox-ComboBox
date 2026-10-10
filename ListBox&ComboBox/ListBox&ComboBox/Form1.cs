using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        private class Service
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public override string ToString() => $"{Name} - {Price:C2}";
        }

        private readonly Dictionary<string, List<Service>> _catalog = new Dictionary<string, List<Service>>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();

            InitializeCatalog();

            cboCategory.Items.AddRange(new object[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // initial load
            LoadAvailableServices();

            // defaults
            nudDiscount.Value = 0;
            RecalculateTotal();
        }

        private void InitializeCatalog()
        {
            _catalog["Khám bệnh"] = new List<Service>
            {
                new Service { Name = "Khám tổng quát", Price = 50m },
                new Service { Name = "Khám chuyên khoa", Price = 80m },
                new Service { Name = "Khám sức khỏe định kỳ", Price = 60m }
            };

            _catalog["Xét nghiệm"] = new List<Service>
            {
                new Service { Name = "Xét nghiệm máu", Price = 30m },
                new Service { Name = "Xét nghiệm nước tiểu", Price = 20m },
                new Service { Name = "Xét nghiệm hormone", Price = 70m }
            };

            _catalog["Chụp X-Quang"] = new List<Service>
            {
                new Service { Name = "X-Quang ngực", Price = 120m },
                new Service { Name = "X-Quang cột sống", Price = 150m }
            };

            _catalog["Vắc-xin"] = new List<Service>
            {
                new Service { Name = "Vắc-xin phòng cúm", Price = 25m },
                new Service { Name = "Vắc-xin phòng viêm gan B", Price = 40m }
            };
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableServices();
        }

        private void LoadAvailableServices()
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem == null) return;
            var key = cboCategory.SelectedItem.ToString();
            if (!_catalog.TryGetValue(key, out var list)) return;
            foreach (var s in list)
                lstAvailableServices.Items.Add(s);
        }

        private void btnSelect_Click(object sender, EventArgs e) => MoveAvailableToSelected();

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e) => MoveAvailableToSelected();

        private void MoveAvailableToSelected()
        {
            if (lstAvailableServices.SelectedItem is Service s)
            {
                lstSelectedServices.Items.Add(s);
                lstAvailableServices.Items.Remove(s);
                RecalculateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem is Service s)
            {
                lstSelectedServices.Items.Remove(s);
                lstAvailableServices.Items.Add(s);
                RecalculateTotal();
            }
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e) => btnRemove_Click(sender, e);

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var items = lstSelectedServices.Items.Cast<Service>().ToList();
            foreach (var it in items)
                lstAvailableServices.Items.Add(it);
            lstSelectedServices.Items.Clear();
            RecalculateTotal();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e) => RecalculateTotal();

        private void RecalculateTotal()
        {
            decimal subtotal = lstSelectedServices.Items.Cast<Service>().Sum(x => x.Price);
            txtTotalBefore.Text = subtotal.ToString("C2");
            decimal discount = nudDiscount?.Value ?? 0m;
            decimal total = subtotal * (1 - discount / 100m);
            txtTotalAfter.Text = total.ToString("C2");
        }
    }
}
