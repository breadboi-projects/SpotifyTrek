namespace SpotifyTrek
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RelatedSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatedView = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Sample = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.currentArtistLabel = new System.Windows.Forms.Label();
            this.finalPlayButton = new System.Windows.Forms.Button();
            this.finalArtistLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPlayButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RelatedSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatedView)).BeginInit();
            this.SuspendLayout();
            // 
            // relatedView
            // 
            this.relatedView.AllowUserToAddRows = false;
            this.relatedView.AllowUserToDeleteRows = false;
            this.relatedView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relatedView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.relatedView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.relatedView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.relatedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relatedView.ColumnHeadersVisible = false;
            this.relatedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Link,
            this.Sample});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.relatedView.DefaultCellStyle = dataGridViewCellStyle1;
            this.relatedView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.relatedView.Location = new System.Drawing.Point(221, 121);
            this.relatedView.Name = "relatedView";
            this.relatedView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.relatedView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.relatedView.RowHeadersVisible = false;
            this.relatedView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.relatedView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.relatedView.RowTemplate.Height = 24;
            this.relatedView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.relatedView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.relatedView.Size = new System.Drawing.Size(447, 156);
            this.relatedView.TabIndex = 0;
            this.relatedView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.relatedView_CellContentClick);
            this.relatedView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.relatedView_CellContentDoubleClick);
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Artist.FillWeight = 50F;
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Link.FillWeight = 25F;
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Text = "Spotify Page";
            this.Link.UseColumnTextForLinkValue = true;
            // 
            // Sample
            // 
            this.Sample.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sample.FillWeight = 25F;
            this.Sample.HeaderText = "Sample";
            this.Sample.Name = "Sample";
            this.Sample.ReadOnly = true;
            this.Sample.Text = "Sample";
            this.Sample.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Artist";
            // 
            // currentArtistLabel
            // 
            this.currentArtistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentArtistLabel.ForeColor = System.Drawing.Color.White;
            this.currentArtistLabel.Location = new System.Drawing.Point(12, 166);
            this.currentArtistLabel.Name = "currentArtistLabel";
            this.currentArtistLabel.Size = new System.Drawing.Size(153, 38);
            this.currentArtistLabel.TabIndex = 2;
            this.currentArtistLabel.Text = "label2";
            this.currentArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalPlayButton
            // 
            this.finalPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalPlayButton.BackColor = System.Drawing.Color.Black;
            this.finalPlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalPlayButton.BackgroundImage")));
            this.finalPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalPlayButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finalPlayButton.Location = new System.Drawing.Point(733, 207);
            this.finalPlayButton.Name = "finalPlayButton";
            this.finalPlayButton.Size = new System.Drawing.Size(70, 70);
            this.finalPlayButton.TabIndex = 6;
            this.finalPlayButton.UseVisualStyleBackColor = false;
            this.finalPlayButton.Click += new System.EventHandler(this.finalPlayButton_ClickAsync);
            // 
            // finalArtistLabel
            // 
            this.finalArtistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalArtistLabel.ForeColor = System.Drawing.Color.White;
            this.finalArtistLabel.Location = new System.Drawing.Point(688, 166);
            this.finalArtistLabel.Name = "finalArtistLabel";
            this.finalArtistLabel.Size = new System.Drawing.Size(178, 38);
            this.finalArtistLabel.TabIndex = 5;
            this.finalArtistLabel.Text = "label2";
            this.finalArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(709, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Goal Artist";
            // 
            // currentPlayButton
            // 
            this.currentPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPlayButton.BackColor = System.Drawing.Color.Black;
            this.currentPlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("currentPlayButton.BackgroundImage")));
            this.currentPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentPlayButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentPlayButton.Location = new System.Drawing.Point(59, 207);
            this.currentPlayButton.Name = "currentPlayButton";
            this.currentPlayButton.Size = new System.Drawing.Size(70, 70);
            this.currentPlayButton.TabIndex = 7;
            this.currentPlayButton.UseVisualStyleBackColor = false;
            this.currentPlayButton.Click += new System.EventHandler(this.currentPlayButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restartButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Location = new System.Drawing.Point(769, 376);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(97, 58);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(878, 446);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.currentPlayButton);
            this.Controls.Add(this.finalPlayButton);
            this.Controls.Add(this.finalArtistLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentArtistLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.relatedView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Spotify Trek";
            ((System.ComponentModel.ISupportInitialize)(this.RelatedSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView relatedView;
        private System.Windows.Forms.BindingSource RelatedSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentArtistLabel;
        private System.Windows.Forms.Button finalPlayButton;
        private System.Windows.Forms.Label finalArtistLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button currentPlayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewButtonColumn Sample;
        private System.Windows.Forms.Button restartButton;
    }
}

