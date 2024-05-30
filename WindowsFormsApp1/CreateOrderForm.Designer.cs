namespace WindowsFormsApp1
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.textBoxApplianceType = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxProblemDescription = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.DataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(633, 462);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 0;
            // 
            // textBoxApplianceType
            // 
            this.textBoxApplianceType.Location = new System.Drawing.Point(633, 501);
            this.textBoxApplianceType.Name = "textBoxApplianceType";
            this.textBoxApplianceType.Size = new System.Drawing.Size(100, 20);
            this.textBoxApplianceType.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(633, 542);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 2;
            // 
            // textBoxProblemDescription
            // 
            this.textBoxProblemDescription.Location = new System.Drawing.Point(633, 585);
            this.textBoxProblemDescription.Name = "textBoxProblemDescription";
            this.textBoxProblemDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxProblemDescription.TabIndex = 3;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(633, 628);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 20);
            this.fioTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(633, 668);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата добавления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид бытовой техники";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Модель бытовой техники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Описание проблемы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ФИО клиента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер телефона";
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CreateOrderButton.Location = new System.Drawing.Point(494, 696);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(205, 48);
            this.CreateOrderButton.TabIndex = 16;
            this.CreateOrderButton.Text = "Создать заявку";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // DataGridViewOrders
            // 
            this.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewOrders.Name = "DataGridViewOrders";
            this.DataGridViewOrders.Size = new System.Drawing.Size(1080, 348);
            this.DataGridViewOrders.TabIndex = 17;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(935, 390);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.DataGridViewOrders);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.textBoxProblemDescription);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxApplianceType);
            this.Controls.Add(this.startDateTextBox);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox textBoxApplianceType;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxProblemDescription;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.DataGridView DataGridViewOrders;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button button1;
    }
}