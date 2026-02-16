namespace MPG_UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textNmbrCylinders = new TextBox();
            label2 = new Label();
            textDisplacement = new TextBox();
            label3 = new Label();
            textHorsepowers = new TextBox();
            label4 = new Label();
            textWeight = new TextBox();
            label5 = new Label();
            textAcceleration = new TextBox();
            btnPredict = new Button();
            lblResult = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 123);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of cylinders";
            // 
            // textNmbrCylinders
            // 
            textNmbrCylinders.Location = new Point(191, 120);
            textNmbrCylinders.Name = "textNmbrCylinders";
            textNmbrCylinders.Size = new Size(100, 23);
            textNmbrCylinders.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 159);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Displacement [cm3]";
            // 
            // textDisplacement
            // 
            textDisplacement.Location = new Point(191, 156);
            textDisplacement.Name = "textDisplacement";
            textDisplacement.Size = new Size(100, 23);
            textDisplacement.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 200);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Horsepowers";
            // 
            // textHorsepowers
            // 
            textHorsepowers.Location = new Point(191, 197);
            textHorsepowers.Name = "textHorsepowers";
            textHorsepowers.Size = new Size(100, 23);
            textHorsepowers.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 241);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Weight [kg]";
            // 
            // textWeight
            // 
            textWeight.Location = new Point(191, 238);
            textWeight.Name = "textWeight";
            textWeight.Size = new Size(100, 23);
            textWeight.TabIndex = 7;
            textWeight.TextChanged += textWeight_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 283);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 8;
            label5.Text = "Acceleration [0-100km/h]";
            // 
            // textAcceleration
            // 
            textAcceleration.Location = new Point(191, 280);
            textAcceleration.Name = "textAcceleration";
            textAcceleration.Size = new Size(100, 23);
            textAcceleration.TabIndex = 9;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(191, 327);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(119, 37);
            btnPredict.TabIndex = 12;
            btnPredict.Text = "Calculate mpg";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += btnPredict_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(225, 391);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 15);
            lblResult.TabIndex = 13;
            lblResult.Text = "RESULT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label6.Location = new Point(214, 19);
            label6.Name = "label6";
            label6.Size = new Size(163, 30);
            label6.TabIndex = 14;
            label6.Text = "MPG Predictor";
            // 
            // Form1
            // 
            ClientSize = new Size(624, 500);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(btnPredict);
            Controls.Add(textAcceleration);
            Controls.Add(label5);
            Controls.Add(textWeight);
            Controls.Add(label4);
            Controls.Add(textHorsepowers);
            Controls.Add(label3);
            Controls.Add(textDisplacement);
            Controls.Add(label2);
            Controls.Add(textNmbrCylinders);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "MPG Predictor";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private Label label1;
        private TextBox textNmbrCylinders;
        private Label label2;
        private TextBox textDisplacement;
        private Label label3;
        private TextBox textHorsepowers;
        private Label label4;
        private TextBox textWeight;
        private Label label5;
        private TextBox textAcceleration;
        private Button btnPredict;
        private Label lblResult;
        private Label label6;
    }
}
