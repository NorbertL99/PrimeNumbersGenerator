namespace Prime_Numbers_Generator
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.upSidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.effectRTB = new System.Windows.Forms.RichTextBox();
            this.stopBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromNumberTB = new System.Windows.Forms.TextBox();
            this.toNumberTB = new System.Windows.Forms.TextBox();
            this.generateFromToBT = new System.Windows.Forms.Button();
            this.fromHowNumberTB = new System.Windows.Forms.TextBox();
            this.howManyTB = new System.Windows.Forms.TextBox();
            this.generateFromHowBT = new System.Windows.Forms.Button();
            this.clearFromToBT = new System.Windows.Forms.Button();
            this.clearFromHowBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.logsL = new System.Windows.Forms.Label();
            this.saveEffect = new System.Windows.Forms.SaveFileDialog();
            this.upSidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upSidePanel
            // 
            this.upSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upSidePanel.Controls.Add(this.label1);
            this.upSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upSidePanel.Location = new System.Drawing.Point(0, 0);
            this.upSidePanel.Name = "upSidePanel";
            this.upSidePanel.Size = new System.Drawing.Size(784, 70);
            this.upSidePanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Controls.Add(this.logsL);
            this.mainPanel.Controls.Add(this.startBT);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.clearFromHowBT);
            this.mainPanel.Controls.Add(this.clearFromToBT);
            this.mainPanel.Controls.Add(this.generateFromHowBT);
            this.mainPanel.Controls.Add(this.howManyTB);
            this.mainPanel.Controls.Add(this.fromHowNumberTB);
            this.mainPanel.Controls.Add(this.generateFromToBT);
            this.mainPanel.Controls.Add(this.toNumberTB);
            this.mainPanel.Controls.Add(this.fromNumberTB);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.saveBT);
            this.mainPanel.Controls.Add(this.clearBT);
            this.mainPanel.Controls.Add(this.stopBT);
            this.mainPanel.Controls.Add(this.effectRTB);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 392);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Numbers Generator";
            // 
            // effectRTB
            // 
            this.effectRTB.Location = new System.Drawing.Point(392, 6);
            this.effectRTB.Name = "effectRTB";
            this.effectRTB.ReadOnly = true;
            this.effectRTB.Size = new System.Drawing.Size(380, 298);
            this.effectRTB.TabIndex = 0;
            this.effectRTB.Text = "";
            // 
            // stopBT
            // 
            this.stopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopBT.Location = new System.Drawing.Point(392, 346);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(123, 43);
            this.stopBT.TabIndex = 1;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearBT.Location = new System.Drawing.Point(521, 346);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(123, 43);
            this.clearBT.TabIndex = 2;
            this.clearBT.Text = "Clear";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveBT.Location = new System.Drawing.Point(649, 346);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(123, 43);
            this.saveBT.TabIndex = 3;
            this.saveBT.Text = "Save to file";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "From number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "To number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(74, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "From - to, generator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(16, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "From - how many, generator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "From number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(36, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "How many:";
            // 
            // fromNumberTB
            // 
            this.fromNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromNumberTB.Location = new System.Drawing.Point(192, 42);
            this.fromNumberTB.Name = "fromNumberTB";
            this.fromNumberTB.Size = new System.Drawing.Size(178, 26);
            this.fromNumberTB.TabIndex = 13;
            // 
            // toNumberTB
            // 
            this.toNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toNumberTB.Location = new System.Drawing.Point(192, 82);
            this.toNumberTB.Name = "toNumberTB";
            this.toNumberTB.Size = new System.Drawing.Size(178, 26);
            this.toNumberTB.TabIndex = 15;
            // 
            // generateFromToBT
            // 
            this.generateFromToBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateFromToBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateFromToBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generateFromToBT.Location = new System.Drawing.Point(192, 114);
            this.generateFromToBT.Name = "generateFromToBT";
            this.generateFromToBT.Size = new System.Drawing.Size(178, 30);
            this.generateFromToBT.TabIndex = 16;
            this.generateFromToBT.Text = "Generate";
            this.generateFromToBT.UseVisualStyleBackColor = true;
            this.generateFromToBT.Click += new System.EventHandler(this.generateFromToBT_Click);
            // 
            // fromHowNumberTB
            // 
            this.fromHowNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromHowNumberTB.Location = new System.Drawing.Point(192, 201);
            this.fromHowNumberTB.Name = "fromHowNumberTB";
            this.fromHowNumberTB.Size = new System.Drawing.Size(178, 26);
            this.fromHowNumberTB.TabIndex = 17;
            // 
            // howManyTB
            // 
            this.howManyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howManyTB.Location = new System.Drawing.Point(192, 240);
            this.howManyTB.Name = "howManyTB";
            this.howManyTB.Size = new System.Drawing.Size(178, 26);
            this.howManyTB.TabIndex = 18;
            // 
            // generateFromHowBT
            // 
            this.generateFromHowBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateFromHowBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateFromHowBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generateFromHowBT.Location = new System.Drawing.Point(192, 274);
            this.generateFromHowBT.Name = "generateFromHowBT";
            this.generateFromHowBT.Size = new System.Drawing.Size(178, 30);
            this.generateFromHowBT.TabIndex = 19;
            this.generateFromHowBT.Text = "Generate";
            this.generateFromHowBT.UseVisualStyleBackColor = true;
            this.generateFromHowBT.Click += new System.EventHandler(this.generateFromHowBT_Click);
            // 
            // clearFromToBT
            // 
            this.clearFromToBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFromToBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearFromToBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearFromToBT.Location = new System.Drawing.Point(8, 114);
            this.clearFromToBT.Name = "clearFromToBT";
            this.clearFromToBT.Size = new System.Drawing.Size(178, 30);
            this.clearFromToBT.TabIndex = 20;
            this.clearFromToBT.Text = "Clear";
            this.clearFromToBT.UseVisualStyleBackColor = true;
            this.clearFromToBT.Click += new System.EventHandler(this.clearFromToBT_Click);
            // 
            // clearFromHowBT
            // 
            this.clearFromHowBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFromHowBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearFromHowBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearFromHowBT.Location = new System.Drawing.Point(8, 274);
            this.clearFromHowBT.Name = "clearFromHowBT";
            this.clearFromHowBT.Size = new System.Drawing.Size(178, 30);
            this.clearFromHowBT.TabIndex = 21;
            this.clearFromHowBT.Text = "Clear";
            this.clearFromHowBT.UseVisualStyleBackColor = true;
            this.clearFromHowBT.Click += new System.EventHandler(this.clearFromHowBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(59, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Generate continuously";
            // 
            // startBT
            // 
            this.startBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startBT.Location = new System.Drawing.Point(101, 341);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(208, 43);
            this.startBT.TabIndex = 23;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // logsL
            // 
            this.logsL.AutoSize = true;
            this.logsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logsL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logsL.Location = new System.Drawing.Point(388, 312);
            this.logsL.Name = "logsL";
            this.logsL.Size = new System.Drawing.Size(143, 24);
            this.logsL.TabIndex = 24;
            this.logsL.Text = "Generating logs";
            // 
            // saveEffect
            // 
            this.saveEffect.Filter = "Text files (*.txt)|*.txt";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Prime Numbers Generator";
            this.upSidePanel.ResumeLayout(false);
            this.upSidePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upSidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearFromHowBT;
        private System.Windows.Forms.Button clearFromToBT;
        private System.Windows.Forms.Button generateFromHowBT;
        private System.Windows.Forms.TextBox howManyTB;
        private System.Windows.Forms.TextBox fromHowNumberTB;
        private System.Windows.Forms.Button generateFromToBT;
        private System.Windows.Forms.TextBox toNumberTB;
        private System.Windows.Forms.TextBox fromNumberTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button stopBT;
        private System.Windows.Forms.RichTextBox effectRTB;
        private System.Windows.Forms.Label logsL;
        private System.Windows.Forms.SaveFileDialog saveEffect;
    }
}

