namespace VixenModules.Editor.TimedSequenceEditor
{
	partial class Form_SavedEffects
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SavedEffects));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			//this.toolStripButtonEditSavedEffectsCollection = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddSavedEffectsCollection = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDeleteSavedEffectsCollection = new System.Windows.Forms.ToolStripButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
		//	this.numericUpDownStandardNudge = new System.Windows.Forms.NumericUpDown();
			//this.numericUpDownSuperNudge = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listViewSavedEffectsCollections = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1.SuspendLayout();
		//	((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardNudge)).BeginInit();
			//((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuperNudge)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
          //  this.//toolStripButtonEditSavedEffectsCollection,
            this.toolStripButtonAddSavedEffectsCollection,
            this.toolStripButtonDeleteSavedEffectsCollection});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(256, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// //toolStripButtonEditSavedEffectsCollection
			// 
            //this.//toolStripButtonEditSavedEffectsCollection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.//toolStripButtonEditSavedEffectsCollection.Image = ((System.Drawing.Image)(resources.GetObject("//toolStripButtonEditSavedEffectsCollection.Image")));
            //this.//toolStripButtonEditSavedEffectsCollection.ImageTransparentColor = System.Drawing.Color.Magenta;
            //this.//toolStripButtonEditSavedEffectsCollection.Name = "//toolStripButtonEditSavedEffectsCollection";
            //this.//toolStripButtonEditSavedEffectsCollection.Size = new System.Drawing.Size(23, 22);
            //this.//toolStripButtonEditSavedEffectsCollection.Text = "//toolStripButtonEditSavedEffectsCollections";
            //this.//toolStripButtonEditSavedEffectsCollection.ToolTipText = "Edit Mark Collections";
            //this.//toolStripButtonEditSavedEffectsCollection.Click += new System.EventHandler(this.//toolStripButtonEditSavedEffectsCollection_Click);
            //// 
			// toolStripButtonAddSavedEffectsCollection
			// 
			this.toolStripButtonAddSavedEffectsCollection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddSavedEffectsCollection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddMarkCollection.Image")));
			this.toolStripButtonAddSavedEffectsCollection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddSavedEffectsCollection.Name = "toolStripButtonAddSavedEffectsCollection";
			this.toolStripButtonAddSavedEffectsCollection.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddSavedEffectsCollection.ToolTipText = "New Saved Effects";
            this.toolStripButtonAddSavedEffectsCollection.Click += new System.EventHandler(this.toolStripButtonAddSavedEffectCollection_Click
);
			// 
			// toolStripButtonDeleteMarkCollection
			// 
			this.toolStripButtonDeleteSavedEffectsCollection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDeleteSavedEffectsCollection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteMarkCollection.Image")));
			this.toolStripButtonDeleteSavedEffectsCollection.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDeleteSavedEffectsCollection.Name = "toolStripButtonDeleteSavedEffectsCollection";
			this.toolStripButtonDeleteSavedEffectsCollection.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDeleteSavedEffectsCollection.Text = "toolStripButtonDeleteSavedEffectsCollection";
			this.toolStripButtonDeleteSavedEffectsCollection.ToolTipText = "Delete Saved Effects";
            this.toolStripButtonDeleteSavedEffectsCollection.Click += new System.EventHandler(this.toolStripButtonDeleteSavedEffectCollection_Click);
			// 
			// numericUpDownStandardNudge
            //// 
            //this.numericUpDownStandardNudge.Location = new System.Drawing.Point(7, 20);
            //this.numericUpDownStandardNudge.Maximum = new decimal(new int[] {
            //1000,
            //0,
            //0,
            //0});
            //this.numericUpDownStandardNudge.Name = "numericUpDownStandardNudge";
            //this.numericUpDownStandardNudge.Size = new System.Drawing.Size(48, 20);
            //this.numericUpDownStandardNudge.TabIndex = 1;
            //this.toolTip1.SetToolTip(this.numericUpDownStandardNudge, "Standard Nudge in Miniseconds");
            //this.numericUpDownStandardNudge.ValueChanged += new System.EventHandler(this.numericUpDownStandardNudge_ValueChanged);
			// 
			// numericUpDownSuperNudge
			// 
		//	this.numericUpDownSuperNudge.Location = new System.Drawing.Point(72, 20);
		//	this.numericUpDownSuperNudge.Maximum = new decimal(new int[] {
            //1000,
            //0,
            //0,
            //0});
            ////this.numericUpDownSuperNudge.Name = "numericUpDownSuperNudge";
            //this.numericUpDownSuperNudge.Size = new System.Drawing.Size(48, 20);
            //this.numericUpDownSuperNudge.TabIndex = 3;
            //this.toolTip1.SetToolTip(this.numericUpDownSuperNudge, "Super Nudge in Miliseconds");
            //this.numericUpDownSuperNudge.ValueChanged += new System.EventHandler(this.numericUpDownSuperNudge_ValueChanged);
            //// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
		//	this.panel1.Controls.Add(this.numericUpDownSuperNudge);
			this.panel1.Controls.Add(this.label2);
			//this.panel1.Controls.Add(this.numericUpDownStandardNudge);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 356);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 46);
			this.panel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nudge";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "/";
			// 
			// listViewMarkCollections
			// 
			this.listViewSavedEffectsCollections.CheckBoxes = true;
			this.listViewSavedEffectsCollections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listViewSavedEffectsCollections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewSavedEffectsCollections.FullRowSelect = true;
			this.listViewSavedEffectsCollections.HideSelection = false;
			this.listViewSavedEffectsCollections.LabelEdit = true;
			this.listViewSavedEffectsCollections.Location = new System.Drawing.Point(0, 25);
			this.listViewSavedEffectsCollections.MultiSelect = false;
			this.listViewSavedEffectsCollections.Name = "listViewSavedEffectsCollections";
			this.listViewSavedEffectsCollections.Scrollable = false;
			this.listViewSavedEffectsCollections.Size = new System.Drawing.Size(256, 331);
			this.listViewSavedEffectsCollections.TabIndex = 8;
			this.listViewSavedEffectsCollections.UseCompatibleStateImageBehavior = false;
			this.listViewSavedEffectsCollections.View = System.Windows.Forms.View.Details;
			this.listViewSavedEffectsCollections.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewSavedEffectsCollections_AfterLabelEdit);
			this.listViewSavedEffectsCollections.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewSavedEffectsCollections_ItemCheck);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Saved Effects Collections";
			this.columnHeader1.Width = 999;
			// 
			// Form_SavedEffects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 402);
			this.ControlBox = false;
			this.Controls.Add(this.listViewSavedEffectsCollections);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_SavedEffects";
			this.Text = "Saved Effects";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SavedEffects_Closing);
			this.Load += new System.EventHandler(this.Form_SavedEffects_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			//((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandardNudge)).EndInit();
			//((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuperNudge)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		//private System.Windows.Forms.ToolStripButton //toolStripButtonEditSavedEffectsCollection;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddSavedEffectsCollection;
		private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSavedEffectsCollection;
		private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.NumericUpDown numericUpDownSuperNudge;
		private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.NumericUpDown numericUpDownStandardNudge;
		private System.Windows.Forms.ListView listViewSavedEffectsCollections;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label label3;
	}
}