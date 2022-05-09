namespace PO_DataConnection
{
    partial class Intro
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
            System.Windows.Forms.Label restnameLabel;
            System.Windows.Forms.Label reststreetLabel;
            System.Windows.Forms.Label restcityLabel;
            System.Windows.Forms.Label restzipcodeLabel;
            System.Windows.Forms.Label raterestLabel;
            System.Windows.Forms.Label reviewrestLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.masterDataSet = new PO_DataConnection.masterDataSet();
            this.userinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userinfoTableAdapter = new PO_DataConnection.masterDataSetTableAdapters.UserinfoTableAdapter();
            this.tableAdapterManager = new PO_DataConnection.masterDataSetTableAdapters.TableAdapterManager();
            this.userinfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userinfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.restnameTextBox = new System.Windows.Forms.TextBox();
            this.reststreetTextBox = new System.Windows.Forms.TextBox();
            this.restcityTextBox = new System.Windows.Forms.TextBox();
            this.restzipcodeTextBox = new System.Windows.Forms.TextBox();
            this.raterestTextBox = new System.Windows.Forms.TextBox();
            this.reviewrestTextBox = new System.Windows.Forms.TextBox();
            this.introsbmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            restnameLabel = new System.Windows.Forms.Label();
            reststreetLabel = new System.Windows.Forms.Label();
            restcityLabel = new System.Windows.Forms.Label();
            restzipcodeLabel = new System.Windows.Forms.Label();
            raterestLabel = new System.Windows.Forms.Label();
            reviewrestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingNavigator)).BeginInit();
            this.userinfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // restnameLabel
            // 
            restnameLabel.AutoSize = true;
            restnameLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restnameLabel.Location = new System.Drawing.Point(84, 151);
            restnameLabel.Name = "restnameLabel";
            restnameLabel.Size = new System.Drawing.Size(129, 20);
            restnameLabel.TabIndex = 5;
            restnameLabel.Text = "Restaurant Name";
            // 
            // reststreetLabel
            // 
            reststreetLabel.AutoSize = true;
            reststreetLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            reststreetLabel.Location = new System.Drawing.Point(84, 195);
            reststreetLabel.Name = "reststreetLabel";
            reststreetLabel.Size = new System.Drawing.Size(130, 20);
            reststreetLabel.TabIndex = 7;
            reststreetLabel.Text = "Restaurant Street:";
            // 
            // restcityLabel
            // 
            restcityLabel.AutoSize = true;
            restcityLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            restcityLabel.Location = new System.Drawing.Point(84, 258);
            restcityLabel.Name = "restcityLabel";
            restcityLabel.Size = new System.Drawing.Size(116, 20);
            restcityLabel.TabIndex = 9;
            restcityLabel.Text = "Restaurant City:";
            // 
            // restzipcodeLabel
            // 
            restzipcodeLabel.AutoSize = true;
            restzipcodeLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            restzipcodeLabel.Location = new System.Drawing.Point(84, 320);
            restzipcodeLabel.Name = "restzipcodeLabel";
            restzipcodeLabel.Size = new System.Drawing.Size(144, 20);
            restzipcodeLabel.TabIndex = 11;
            restzipcodeLabel.Text = "Restaurant Zipcode:";
            // 
            // raterestLabel
            // 
            raterestLabel.AutoSize = true;
            raterestLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            raterestLabel.Location = new System.Drawing.Point(84, 378);
            raterestLabel.Name = "raterestLabel";
            raterestLabel.Size = new System.Drawing.Size(122, 20);
            raterestLabel.TabIndex = 13;
            raterestLabel.Text = "Rate Restaurant:";
            // 
            // reviewrestLabel
            // 
            reviewrestLabel.AutoSize = true;
            reviewrestLabel.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold);
            reviewrestLabel.Location = new System.Drawing.Point(84, 423);
            reviewrestLabel.Name = "reviewrestLabel";
            reviewrestLabel.Size = new System.Drawing.Size(137, 20);
            reviewrestLabel.TabIndex = 15;
            reviewrestLabel.Text = "Review Restaurant:";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userinfoBindingSource
            // 
            this.userinfoBindingSource.DataMember = "Userinfo";
            this.userinfoBindingSource.DataSource = this.masterDataSet;
            // 
            // userinfoTableAdapter
            // 
            this.userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PO_DataConnection.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserinfoTableAdapter = this.userinfoTableAdapter;
            // 
            // userinfoBindingNavigator
            // 
            this.userinfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userinfoBindingNavigator.BindingSource = this.userinfoBindingSource;
            this.userinfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userinfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userinfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userinfoBindingNavigatorSaveItem});
            this.userinfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userinfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userinfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userinfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userinfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userinfoBindingNavigator.Name = "userinfoBindingNavigator";
            this.userinfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userinfoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.userinfoBindingNavigator.TabIndex = 0;
            this.userinfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userinfoBindingNavigatorSaveItem
            // 
            this.userinfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userinfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userinfoBindingNavigatorSaveItem.Image")));
            this.userinfoBindingNavigatorSaveItem.Name = "userinfoBindingNavigatorSaveItem";
            this.userinfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userinfoBindingNavigatorSaveItem.Text = "Save Data";
            this.userinfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.userinfoBindingNavigatorSaveItem_Click);
            // 
            // restnameTextBox
            // 
            this.restnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "restname", true));
            this.restnameTextBox.Location = new System.Drawing.Point(240, 151);
            this.restnameTextBox.Name = "restnameTextBox";
            this.restnameTextBox.Size = new System.Drawing.Size(412, 20);
            this.restnameTextBox.TabIndex = 6;
            // 
            // reststreetTextBox
            // 
            this.reststreetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "reststreet", true));
            this.reststreetTextBox.Location = new System.Drawing.Point(240, 195);
            this.reststreetTextBox.Name = "reststreetTextBox";
            this.reststreetTextBox.Size = new System.Drawing.Size(412, 20);
            this.reststreetTextBox.TabIndex = 8;
            // 
            // restcityTextBox
            // 
            this.restcityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "restcity", true));
            this.restcityTextBox.Location = new System.Drawing.Point(240, 260);
            this.restcityTextBox.Name = "restcityTextBox";
            this.restcityTextBox.Size = new System.Drawing.Size(412, 20);
            this.restcityTextBox.TabIndex = 10;
            // 
            // restzipcodeTextBox
            // 
            this.restzipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "restzipcode", true));
            this.restzipcodeTextBox.Location = new System.Drawing.Point(240, 320);
            this.restzipcodeTextBox.Name = "restzipcodeTextBox";
            this.restzipcodeTextBox.Size = new System.Drawing.Size(412, 20);
            this.restzipcodeTextBox.TabIndex = 12;
            // 
            // raterestTextBox
            // 
            this.raterestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "raterest", true));
            this.raterestTextBox.Location = new System.Drawing.Point(240, 378);
            this.raterestTextBox.Name = "raterestTextBox";
            this.raterestTextBox.Size = new System.Drawing.Size(412, 20);
            this.raterestTextBox.TabIndex = 14;
            // 
            // reviewrestTextBox
            // 
            this.reviewrestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userinfoBindingSource, "reviewrest", true));
            this.reviewrestTextBox.Location = new System.Drawing.Point(240, 423);
            this.reviewrestTextBox.Name = "reviewrestTextBox";
            this.reviewrestTextBox.Size = new System.Drawing.Size(412, 20);
            this.reviewrestTextBox.TabIndex = 16;
            // 
            // introsbmit
            // 
            this.introsbmit.Font = new System.Drawing.Font("Josefin Sans", 15.75F, System.Drawing.FontStyle.Bold);
            this.introsbmit.Location = new System.Drawing.Point(301, 481);
            this.introsbmit.Name = "introsbmit";
            this.introsbmit.Size = new System.Drawing.Size(262, 48);
            this.introsbmit.TabIndex = 17;
            this.introsbmit.Text = "Submit";
            this.introsbmit.UseVisualStyleBackColor = true;
            this.introsbmit.Click += new System.EventHandler(this.introsbmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome. Enter information below to review";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.introsbmit);
            this.Controls.Add(reviewrestLabel);
            this.Controls.Add(this.reviewrestTextBox);
            this.Controls.Add(raterestLabel);
            this.Controls.Add(this.raterestTextBox);
            this.Controls.Add(restzipcodeLabel);
            this.Controls.Add(this.restzipcodeTextBox);
            this.Controls.Add(restcityLabel);
            this.Controls.Add(this.restcityTextBox);
            this.Controls.Add(reststreetLabel);
            this.Controls.Add(this.reststreetTextBox);
            this.Controls.Add(restnameLabel);
            this.Controls.Add(this.restnameTextBox);
            this.Controls.Add(this.userinfoBindingNavigator);
            this.Name = "Intro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userinfoBindingNavigator)).EndInit();
            this.userinfoBindingNavigator.ResumeLayout(false);
            this.userinfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource userinfoBindingSource;
        private masterDataSetTableAdapters.UserinfoTableAdapter userinfoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userinfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userinfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox restnameTextBox;
        private System.Windows.Forms.TextBox reststreetTextBox;
        private System.Windows.Forms.TextBox restcityTextBox;
        private System.Windows.Forms.TextBox restzipcodeTextBox;
        private System.Windows.Forms.TextBox raterestTextBox;
        private System.Windows.Forms.TextBox reviewrestTextBox;
        private System.Windows.Forms.Button introsbmit;
        private System.Windows.Forms.Label label1;
    }
}

