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
    public partial class CreateOrderForm : Form
    {
        private DB db = new DB();

        public CreateOrderForm()
        {
            InitializeComponent();
            LoadCurrentUser();
            SetCurrentDate();
            LoadForm();
            LoadStatuses();
        }

        private void LoadForm()
        {
            DataGridViewOrders.DataSource = db.Requests.ToList();
        }

        private void LoadCurrentUser()
        {
            Users currentUser = Auth.currentUser;
            if (currentUser != null)
            {
                fioTextBox.Text = currentUser.fio;
                fioTextBox.Enabled = false;
                phoneTextBox.Text = currentUser.phone;
                phoneTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ошибка: текущий пользователь не определен.");
                this.Close();
            }
        }

        private void SetCurrentDate()
        {
            startDateTextBox.Text = DateTime.Now.ToShortDateString();
            startDateTextBox.ReadOnly = true;
        }

        public void LoadStatuses()
        {
            // Загрузка статусов из базы данных
            var statuses = db.Status.ToList();

            // Установка значения "Новая заявка" по умолчанию и блокировка для изменений
            var defaultStatus = statuses.FirstOrDefault(s => s.Status_ID == 3);
            statusComboBox.SelectedItem = defaultStatus;
            statusComboBox.Enabled = false;
        }

        public void buttonAddRequest_Click(object sender, EventArgs e)
        {
            var statuses = db.Status.ToList();
            var defaultStatus = statuses.FirstOrDefault(s => s.Status_ID == 3);
            statusComboBox.SelectedItem = defaultStatus;
            statusComboBox.Enabled = false;
            try
            {
                Users client = Auth.currentUser;

                if (client == null)
                {
                    MessageBox.Show("Не удалось определить текущего пользователя.");
                    return;
                }

                Requests request = new Requests
                {
                    requestID = GetNextRequestID(),
                    startDate = DateTime.Now,
                    homeTechType = textBoxApplianceType.Text,
                    homeTechModel = textBoxModel.Text,
                    problemDescription = textBoxProblemDescription.Text,
                    Status_ID = 3,
                    masterID = 1,
                    clientID = client.userID,
                    clientPhone = client.phone
                };

                db.Requests.Add(request);
                db.SaveChanges();

                MessageBox.Show("Заявка успешно добавлена.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении заявки: {ex.Message}");
            }
        }

        private int GetNextRequestID()
        {
            int lastRequestID = db.Requests.OrderByDescending(r => r.requestID).FirstOrDefault()?.requestID ?? 0;
            return lastRequestID + 1;
        }

        private void ClearForm()
        {
            textBoxApplianceType.Text = "";
            textBoxModel.Text = "";
            textBoxProblemDescription.Text = "";
        }
    }
}

