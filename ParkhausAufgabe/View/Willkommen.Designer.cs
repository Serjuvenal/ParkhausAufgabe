namespace ParkhausAufgabe
{
    partial class Willkommen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_willkommen = new Label();
            lbl_anzahletagen = new Label();
            lbl_parkplaetzeproetage = new Label();
            lbl_parametern = new Label();
            btn_starten = new Button();
            btn_beenden = new Button();
            tb_anzahletagen = new TextBox();
            tb_parkplaetzeproetage = new TextBox();
            SuspendLayout();
            // 
            // lbl_willkommen
            // 
            lbl_willkommen.AutoSize = true;
            lbl_willkommen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_willkommen.Location = new Point(47, 9);
            lbl_willkommen.Name = "lbl_willkommen";
            lbl_willkommen.Size = new Size(239, 50);
            lbl_willkommen.TabIndex = 5;
            lbl_willkommen.Text = "Willkommen im Parkhaus\r\nSIMULATOR\r\n";
            lbl_willkommen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_anzahletagen
            // 
            lbl_anzahletagen.AutoSize = true;
            lbl_anzahletagen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_anzahletagen.Location = new Point(64, 163);
            lbl_anzahletagen.Name = "lbl_anzahletagen";
            lbl_anzahletagen.Size = new Size(119, 17);
            lbl_anzahletagen.TabIndex = 7;
            lbl_anzahletagen.Text = "Anzahl der Etagen\r\n";
            lbl_anzahletagen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_parkplaetzeproetage
            // 
            lbl_parkplaetzeproetage.AutoSize = true;
            lbl_parkplaetzeproetage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_parkplaetzeproetage.Location = new Point(45, 202);
            lbl_parkplaetzeproetage.Name = "lbl_parkplaetzeproetage";
            lbl_parkplaetzeproetage.Size = new Size(141, 17);
            lbl_parkplaetzeproetage.TabIndex = 8;
            lbl_parkplaetzeproetage.Text = "Parkplaetze pro Etage";
            lbl_parkplaetzeproetage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_parametern
            // 
            lbl_parametern.AutoSize = true;
            lbl_parametern.BackColor = Color.Transparent;
            lbl_parametern.Location = new Point(65, 91);
            lbl_parametern.Name = "lbl_parametern";
            lbl_parametern.Size = new Size(206, 45);
            lbl_parametern.TabIndex = 6;
            lbl_parametern.Text = "Bitte geben Sie folgenden Parametern\r\num zu starten...\r\n\r\n";
            lbl_parametern.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_starten
            // 
            btn_starten.BackColor = Color.Chartreuse;
            btn_starten.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_starten.Location = new Point(71, 266);
            btn_starten.Name = "btn_starten";
            btn_starten.Size = new Size(87, 44);
            btn_starten.TabIndex = 2;
            btn_starten.Text = "Starten";
            btn_starten.UseVisualStyleBackColor = false;
            btn_starten.Click += btn_starten_Click;
            // 
            // btn_beenden
            // 
            btn_beenden.BackColor = Color.LightCoral;
            btn_beenden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_beenden.Location = new Point(164, 266);
            btn_beenden.Name = "btn_beenden";
            btn_beenden.Size = new Size(87, 44);
            btn_beenden.TabIndex = 3;
            btn_beenden.Text = "Beenden";
            btn_beenden.UseVisualStyleBackColor = false;
            btn_beenden.Click += btn_beenden_Click;
            // 
            // tb_anzahletagen
            // 
            tb_anzahletagen.Location = new Point(189, 163);
            tb_anzahletagen.Name = "tb_anzahletagen";
            tb_anzahletagen.Size = new Size(62, 23);
            tb_anzahletagen.TabIndex = 0;
            tb_anzahletagen.TextAlign = HorizontalAlignment.Center;
            tb_anzahletagen.KeyPress += tb_anzahletagen_KeyPress;
            // 
            // tb_parkplaetzeproetage
            // 
            tb_parkplaetzeproetage.Location = new Point(189, 201);
            tb_parkplaetzeproetage.Name = "tb_parkplaetzeproetage";
            tb_parkplaetzeproetage.Size = new Size(62, 23);
            tb_parkplaetzeproetage.TabIndex = 1;
            tb_parkplaetzeproetage.TextAlign = HorizontalAlignment.Center;
            tb_parkplaetzeproetage.KeyPress += tb_parkplaetzeproetage_KeyPress;
            // 
            // Willkommen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(342, 322);
            Controls.Add(tb_parkplaetzeproetage);
            Controls.Add(tb_anzahletagen);
            Controls.Add(btn_beenden);
            Controls.Add(btn_starten);
            Controls.Add(lbl_parkplaetzeproetage);
            Controls.Add(lbl_anzahletagen);
            Controls.Add(lbl_parametern);
            Controls.Add(lbl_willkommen);
            Name = "Willkommen";
            Text = "Parkhaus GmbH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_willkommen;
        private Label lbl_anzahletagen;
        private Label lbl_parkplaetzeproetage;
        private Label lbl_parametern;
        private Button btn_starten;
        private Button btn_beenden;
        private TextBox tb_anzahletagen;
        private TextBox tb_parkplaetzeproetage;
    }
}