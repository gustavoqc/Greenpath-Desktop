﻿namespace Project.Controls
{
    partial class ControlPanel
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (timerData != null)
                {
                    timerData.Stop();
                    timerData.Dispose();
                }
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tspCont = new ToolStrip();
            btnInventory = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnTransactions = new ToolStripDropDownButton();
            btnActiveTrans = new ToolStripMenuItem();
            btnHistoryTrans = new ToolStripMenuItem();
            pgbData = new ToolStripProgressBar();
            btnUpdateInv = new ToolStripButton();
            btnUpdateProduct = new ToolStripButton();
            btnDeleteProd = new ToolStripButton();
            btnApprove = new ToolStripButton();
            btnDeny = new ToolStripButton();
            pnlProduct = new Panel();
            editProduct = new Panel();
            numValue = new NumericUpDown();
            label1 = new Label();
            label7 = new Label();
            txtDesc = new TextBox();
            imgProd = new PictureBox();
            btnEditProduct = new Button();
            label10 = new Label();
            cmbCateg = new ComboBox();
            label11 = new Label();
            txtProductName = new TextBox();
            label12 = new Label();
            txtProdId = new TextBox();
            gridInv = new DataGridView();
            timerData = new System.Windows.Forms.Timer(components);
            openFile = new OpenFileDialog();
            tspCont.SuspendLayout();
            pnlProduct.SuspendLayout();
            editProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgProd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridInv).BeginInit();
            SuspendLayout();
            // 
            // tspCont
            // 
            tspCont.BackColor = Color.FromArgb(224, 224, 224);
            tspCont.Font = new Font("Arial", 10F);
            tspCont.GripStyle = ToolStripGripStyle.Hidden;
            tspCont.ImageScalingSize = new Size(50, 50);
            tspCont.Items.AddRange(new ToolStripItem[] { btnInventory, toolStripSeparator1, btnTransactions, pgbData, btnUpdateInv, btnUpdateProduct, btnDeleteProd, btnApprove, btnDeny });
            tspCont.Location = new Point(0, 0);
            tspCont.Name = "tspCont";
            tspCont.Size = new Size(662, 35);
            tspCont.TabIndex = 1;
            // 
            // btnInventory
            // 
            btnInventory.AutoSize = false;
            btnInventory.BackColor = Color.Transparent;
            btnInventory.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInventory.Font = new Font("Arial", 11F);
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageTransparentColor = Color.FromArgb(192, 255, 192);
            btnInventory.Margin = new Padding(10, 5, 0, 5);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(1);
            btnInventory.Size = new Size(115, 25);
            btnInventory.Text = "Estoque";
            btnInventory.Click += BtnInventory_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.BackColor = Color.Black;
            toolStripSeparator1.ForeColor = Color.Black;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(25, 30);
            // 
            // btnTransactions
            // 
            btnTransactions.AutoSize = false;
            btnTransactions.BackColor = Color.FromArgb(224, 224, 224);
            btnTransactions.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTransactions.DropDownItems.AddRange(new ToolStripItem[] { btnActiveTrans, btnHistoryTrans });
            btnTransactions.Font = new Font("Arial", 11F);
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageTransparentColor = Color.Magenta;
            btnTransactions.Margin = new Padding(0, 5, 5, 5);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Padding = new Padding(1);
            btnTransactions.Size = new Size(115, 25);
            btnTransactions.Text = "Transações";
            // 
            // btnActiveTrans
            // 
            btnActiveTrans.BackColor = Color.Transparent;
            btnActiveTrans.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnActiveTrans.Name = "btnActiveTrans";
            btnActiveTrans.Size = new Size(133, 22);
            btnActiveTrans.Text = "Ativas";
            btnActiveTrans.Click += btnActiveTrans_Click;
            // 
            // btnHistoryTrans
            // 
            btnHistoryTrans.BackColor = Color.Transparent;
            btnHistoryTrans.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnHistoryTrans.ForeColor = SystemColors.ControlText;
            btnHistoryTrans.Name = "btnHistoryTrans";
            btnHistoryTrans.Size = new Size(133, 22);
            btnHistoryTrans.Text = "Histórico";
            btnHistoryTrans.Click += btnHistoryTrans_Click;
            // 
            // pgbData
            // 
            pgbData.Alignment = ToolStripItemAlignment.Right;
            pgbData.AutoSize = false;
            pgbData.Margin = new Padding(0, 0, 25, 0);
            pgbData.MarqueeAnimationSpeed = 35;
            pgbData.Name = "pgbData";
            pgbData.RightToLeft = RightToLeft.No;
            pgbData.Size = new Size(100, 15);
            pgbData.Style = ProgressBarStyle.Marquee;
            // 
            // btnUpdateInv
            // 
            btnUpdateInv.AutoSize = false;
            btnUpdateInv.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdateInv.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUpdateInv.Font = new Font("Arial", 16F);
            btnUpdateInv.Image = Properties.Resources.updateInv;
            btnUpdateInv.ImageTransparentColor = Color.BlueViolet;
            btnUpdateInv.Margin = new Padding(130, 0, 5, 0);
            btnUpdateInv.Name = "btnUpdateInv";
            btnUpdateInv.Size = new Size(28, 28);
            btnUpdateInv.TextImageRelation = TextImageRelation.TextAboveImage;
            btnUpdateInv.ToolTipText = "Atualizar Estoque Selecionado";
            btnUpdateInv.Visible = false;
            btnUpdateInv.Click += btnUpdateInv_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.AutoSize = false;
            btnUpdateProduct.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUpdateProduct.Font = new Font("Arial", 12F);
            btnUpdateProduct.Image = Properties.Resources.updateProd;
            btnUpdateProduct.ImageTransparentColor = Color.Magenta;
            btnUpdateProduct.Margin = new Padding(0, 0, 5, 0);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(28, 28);
            btnUpdateProduct.TextImageRelation = TextImageRelation.TextAboveImage;
            btnUpdateProduct.ToolTipText = "Atualizar Produto Selecionado";
            btnUpdateProduct.Visible = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.AutoSize = false;
            btnDeleteProd.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteProd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteProd.Font = new Font("Arial", 12F);
            btnDeleteProd.Image = Properties.Resources.delete;
            btnDeleteProd.ImageTransparentColor = Color.Magenta;
            btnDeleteProd.Margin = new Padding(0, 0, 5, 0);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(28, 28);
            btnDeleteProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteProd.ToolTipText = "Excluir Produto";
            btnDeleteProd.Visible = false;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // btnApprove
            // 
            btnApprove.AutoSize = false;
            btnApprove.BackgroundImageLayout = ImageLayout.Stretch;
            btnApprove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnApprove.Font = new Font("Arial", 12F);
            btnApprove.Image = Properties.Resources.approve;
            btnApprove.ImageTransparentColor = Color.Magenta;
            btnApprove.Margin = new Padding(145, 0, 5, 0);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(28, 28);
            btnApprove.TextImageRelation = TextImageRelation.TextAboveImage;
            btnApprove.ToolTipText = "Validar Transação";
            btnApprove.Visible = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDeny
            // 
            btnDeny.AutoSize = false;
            btnDeny.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeny.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeny.Font = new Font("Arial", 12F);
            btnDeny.Image = Properties.Resources.delete;
            btnDeny.ImageTransparentColor = Color.Magenta;
            btnDeny.Margin = new Padding(0, 0, 5, 0);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(28, 28);
            btnDeny.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDeny.ToolTipText = "Invalidar Transação";
            btnDeny.Visible = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // pnlProduct
            // 
            pnlProduct.BackColor = Color.FromArgb(224, 224, 224);
            pnlProduct.Controls.Add(editProduct);
            pnlProduct.Controls.Add(gridInv);
            pnlProduct.Dock = DockStyle.Fill;
            pnlProduct.Location = new Point(0, 35);
            pnlProduct.Margin = new Padding(5);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Padding = new Padding(15, 10, 15, 15);
            pnlProduct.Size = new Size(662, 289);
            pnlProduct.TabIndex = 13;
            // 
            // editProduct
            // 
            editProduct.BackColor = Color.FromArgb(224, 224, 224);
            editProduct.Controls.Add(numValue);
            editProduct.Controls.Add(label1);
            editProduct.Controls.Add(label7);
            editProduct.Controls.Add(txtDesc);
            editProduct.Controls.Add(imgProd);
            editProduct.Controls.Add(btnEditProduct);
            editProduct.Controls.Add(label10);
            editProduct.Controls.Add(cmbCateg);
            editProduct.Controls.Add(label11);
            editProduct.Controls.Add(txtProductName);
            editProduct.Controls.Add(label12);
            editProduct.Controls.Add(txtProdId);
            editProduct.Dock = DockStyle.Fill;
            editProduct.Location = new Point(15, 10);
            editProduct.Name = "editProduct";
            editProduct.Size = new Size(632, 264);
            editProduct.TabIndex = 1;
            editProduct.Visible = false;
            editProduct.VisibleChanged += editProduct_VisibleChanged;
            // 
            // numValue
            // 
            numValue.DecimalPlaces = 2;
            numValue.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numValue.Location = new Point(75, 112);
            numValue.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numValue.Name = "numValue";
            numValue.Size = new Size(104, 26);
            numValue.TabIndex = 35;
            numValue.TextAlign = HorizontalAlignment.Center;
            numValue.ThousandsSeparator = true;
            numValue.KeyPress += numValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(44, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 18);
            label1.TabIndex = 34;
            label1.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(18, 194);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 32;
            label7.Text = "Desc.";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.White;
            txtDesc.Location = new Point(75, 160);
            txtDesc.Margin = new Padding(4);
            txtDesc.MinimumSize = new Size(256, 90);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(302, 90);
            txtDesc.TabIndex = 26;
            // 
            // imgProd
            // 
            imgProd.BorderStyle = BorderStyle.FixedSingle;
            imgProd.Image = Properties.Resources.images;
            imgProd.InitialImage = Properties.Resources.images;
            imgProd.Location = new Point(427, 23);
            imgProd.Margin = new Padding(4);
            imgProd.Name = "imgProd";
            imgProd.Size = new Size(176, 157);
            imgProd.SizeMode = PictureBoxSizeMode.StretchImage;
            imgProd.TabIndex = 31;
            imgProd.TabStop = false;
            imgProd.Click += imgProd_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.AutoSize = true;
            btnEditProduct.BackColor = Color.LightGray;
            btnEditProduct.FlatAppearance.BorderColor = Color.Black;
            btnEditProduct.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEditProduct.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEditProduct.ForeColor = Color.Black;
            btnEditProduct.Location = new Point(434, 201);
            btnEditProduct.Margin = new Padding(6, 6, 0, 6);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(161, 42);
            btnEditProduct.TabIndex = 29;
            btnEditProduct.Tag = "";
            btnEditProduct.Text = "Salvar";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(23, 114);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 18);
            label10.TabIndex = 28;
            label10.Text = "Valor";
            // 
            // cmbCateg
            // 
            cmbCateg.BackColor = Color.White;
            cmbCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCateg.FlatStyle = FlatStyle.Flat;
            cmbCateg.FormattingEnabled = true;
            cmbCateg.Location = new Point(257, 111);
            cmbCateg.Margin = new Padding(4);
            cmbCateg.Name = "cmbCateg";
            cmbCateg.RightToLeft = RightToLeft.No;
            cmbCateg.Size = new Size(120, 26);
            cmbCateg.Sorted = true;
            cmbCateg.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(195, 115);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 18);
            label11.TabIndex = 24;
            label11.Text = "Categ.";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(75, 62);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(302, 26);
            txtProductName.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(17, 64);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 18);
            label12.TabIndex = 21;
            label12.Text = "Nome";
            // 
            // txtProdId
            // 
            txtProdId.Enabled = false;
            txtProdId.HideSelection = false;
            txtProdId.Location = new Point(75, 20);
            txtProdId.Name = "txtProdId";
            txtProdId.ReadOnly = true;
            txtProdId.Size = new Size(91, 26);
            txtProdId.TabIndex = 1;
            // 
            // gridInv
            // 
            gridInv.AllowUserToAddRows = false;
            gridInv.AllowUserToDeleteRows = false;
            gridInv.AllowUserToResizeColumns = false;
            gridInv.AllowUserToResizeRows = false;
            gridInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridInv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridInv.BackgroundColor = Color.FromArgb(224, 224, 224);
            gridInv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridInv.DefaultCellStyle = dataGridViewCellStyle2;
            gridInv.Dock = DockStyle.Fill;
            gridInv.EnableHeadersVisualStyles = false;
            gridInv.GridColor = Color.Black;
            gridInv.Location = new Point(15, 10);
            gridInv.MultiSelect = false;
            gridInv.Name = "gridInv";
            gridInv.ReadOnly = true;
            gridInv.RowHeadersVisible = false;
            gridInv.ScrollBars = ScrollBars.Vertical;
            gridInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridInv.Size = new Size(632, 264);
            gridInv.TabIndex = 0;
            gridInv.CellFormatting += GridInv_CellFormatting;
            gridInv.SelectionChanged += gridInv_SelectionChanged;
            // 
            // timerData
            // 
            timerData.Enabled = true;
            timerData.Interval = 300000;
            timerData.Tick += TimerData_Tick;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlProduct);
            Controls.Add(tspCont);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4);
            Name = "ControlPanel";
            Size = new Size(662, 324);
            Load += ControlPanel_Load;
            tspCont.ResumeLayout(false);
            tspCont.PerformLayout();
            pnlProduct.ResumeLayout(false);
            editProduct.ResumeLayout(false);
            editProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgProd).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridInv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tspCont;
        private ToolStripButton btnInventory;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton btnTransactions;
        private ToolStripMenuItem btnActiveTrans;
        private ToolStripMenuItem btnHistoryTrans;
        private Panel pnlProduct;
        private ToolStripProgressBar pgbData;
        private System.Windows.Forms.Timer timerData;
        private DataGridView gridInv;
        private ToolStripButton btnUpdateProduct;
        private ToolStripButton btnUpdateInv;
        private ToolStripButton btnDeleteProd;
        private ToolStripButton btnApprove;
        private ToolStripButton btnDeny;
        private Panel editProduct;
        private Label label7;
        private TextBox txtDesc;
        private PictureBox imgProd;
        private Button btnEditProduct;
        private Label label10;
        private ComboBox cmbCateg;
        private Label label11;
        private TextBox txtProductName;
        private Label label12;
        private TextBox txtProdId;
        private Label label1;
        private NumericUpDown numValue;
        private OpenFileDialog openFile;
    }
}