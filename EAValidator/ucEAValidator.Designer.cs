﻿namespace EAValidator
{
    partial class ucEAValidator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoValidation = new System.Windows.Forms.Button();
            this.olvValidations = new BrightIdeasSoftware.ObjectListView();
            this.olvColCheck = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColEAItemType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColItemName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColElementType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColElementStereotype = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageParentLvl1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageParentLvl2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageParentLvl3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageParentLvl4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPackageParentLvl5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColWarningType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColProposedSolution = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvChecks = new BrightIdeasSoftware.ObjectListView();
            this.olvColCheckDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckNumberOfElementsFound = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckNumberOfValidationResults = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckWarningType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCheckRationale = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblChecks = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.btnSelectElement = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblElementName = new System.Windows.Forms.Label();
            this.grpElement = new System.Windows.Forms.GroupBox();
            this.btnClearScope = new System.Windows.Forms.Button();
            this.txtDiagramName = new System.Windows.Forms.TextBox();
            this.lblDiagram = new System.Windows.Forms.Label();
            this.btnSelectDiagram = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvValidations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvChecks)).BeginInit();
            this.grpElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoValidation
            // 
            this.btnDoValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoValidation.Location = new System.Drawing.Point(903, 321);
            this.btnDoValidation.Name = "btnDoValidation";
            this.btnDoValidation.Size = new System.Drawing.Size(82, 25);
            this.btnDoValidation.TabIndex = 0;
            this.btnDoValidation.Text = "Validate!";
            this.btnDoValidation.UseVisualStyleBackColor = true;
            this.btnDoValidation.Click += new System.EventHandler(this.btnDoValidation_Click);
            // 
            // olvValidations
            // 
            this.olvValidations.AllColumns.Add(this.olvColCheck);
            this.olvValidations.AllColumns.Add(this.olvColEAItemType);
            this.olvValidations.AllColumns.Add(this.olvColItemName);
            this.olvValidations.AllColumns.Add(this.olvColElementType);
            this.olvValidations.AllColumns.Add(this.olvColElementStereotype);
            this.olvValidations.AllColumns.Add(this.olvColPackageName);
            this.olvValidations.AllColumns.Add(this.olvColPackageParentLvl1);
            this.olvValidations.AllColumns.Add(this.olvColPackageParentLvl2);
            this.olvValidations.AllColumns.Add(this.olvColPackageParentLvl3);
            this.olvValidations.AllColumns.Add(this.olvColPackageParentLvl4);
            this.olvValidations.AllColumns.Add(this.olvColPackageParentLvl5);
            this.olvValidations.AllColumns.Add(this.olvColWarningType);
            this.olvValidations.AllColumns.Add(this.olvColProposedSolution);
            this.olvValidations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvValidations.CellEditUseWholeCell = false;
            this.olvValidations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColCheck,
            this.olvColEAItemType,
            this.olvColItemName,
            this.olvColElementType,
            this.olvColElementStereotype,
            this.olvColPackageName,
            this.olvColPackageParentLvl1,
            this.olvColPackageParentLvl2,
            this.olvColPackageParentLvl3,
            this.olvColPackageParentLvl4,
            this.olvColPackageParentLvl5,
            this.olvColWarningType,
            this.olvColProposedSolution});
            this.olvValidations.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvValidations.Location = new System.Drawing.Point(14, 367);
            this.olvValidations.Name = "olvValidations";
            this.olvValidations.Size = new System.Drawing.Size(971, 317);
            this.olvValidations.TabIndex = 2;
            this.olvValidations.UseCompatibleStateImageBehavior = false;
            this.olvValidations.View = System.Windows.Forms.View.Details;
            this.olvValidations.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvValidations_CellToolTipShowing);
            this.olvValidations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvValidations_MouseDoubleClick);
            // 
            // olvColCheck
            // 
            this.olvColCheck.AspectName = "CheckDescription";
            this.olvColCheck.IsEditable = false;
            this.olvColCheck.Text = "Check Description";
            this.olvColCheck.Width = 64;
            // 
            // olvColEAItemType
            // 
            this.olvColEAItemType.AspectName = "EAItemType";
            this.olvColEAItemType.Text = "Type";
            this.olvColEAItemType.Width = 102;
            // 
            // olvColItemName
            // 
            this.olvColItemName.AspectName = "ItemName";
            this.olvColItemName.IsEditable = false;
            this.olvColItemName.Text = "Item";
            this.olvColItemName.Width = 339;
            // 
            // olvColElementType
            // 
            this.olvColElementType.AspectName = "ElementType";
            this.olvColElementType.IsEditable = false;
            this.olvColElementType.Text = "Element Type";
            this.olvColElementType.Width = 124;
            // 
            // olvColElementStereotype
            // 
            this.olvColElementStereotype.AspectName = "ElementStereotype";
            this.olvColElementStereotype.IsEditable = false;
            this.olvColElementStereotype.Text = "Element Stereotype";
            this.olvColElementStereotype.Width = 152;
            // 
            // olvColPackageName
            // 
            this.olvColPackageName.AspectName = "PackageName";
            this.olvColPackageName.IsEditable = false;
            this.olvColPackageName.Text = "Package";
            this.olvColPackageName.Width = 161;
            // 
            // olvColPackageParentLvl1
            // 
            this.olvColPackageParentLvl1.AspectName = "PackageParentLevel1";
            this.olvColPackageParentLvl1.Text = "Pckg+1";
            this.olvColPackageParentLvl1.Width = 83;
            // 
            // olvColPackageParentLvl2
            // 
            this.olvColPackageParentLvl2.AspectName = "PackageParentLevel2";
            this.olvColPackageParentLvl2.Text = "Pckg+2";
            this.olvColPackageParentLvl2.Width = 81;
            // 
            // olvColPackageParentLvl3
            // 
            this.olvColPackageParentLvl3.AspectName = "PackageParentLevel3";
            this.olvColPackageParentLvl3.Text = "Pckg+3";
            this.olvColPackageParentLvl3.Width = 79;
            // 
            // olvColPackageParentLvl4
            // 
            this.olvColPackageParentLvl4.AspectName = "PackageParentLevel4";
            this.olvColPackageParentLvl4.Text = "Pckg+4";
            this.olvColPackageParentLvl4.Width = 68;
            // 
            // olvColPackageParentLvl5
            // 
            this.olvColPackageParentLvl5.AspectName = "PackageParentLevel5";
            this.olvColPackageParentLvl5.Text = "Pckg+5";
            this.olvColPackageParentLvl5.Width = 74;
            // 
            // olvColWarningType
            // 
            this.olvColWarningType.AspectName = "CheckWarningType";
            this.olvColWarningType.Text = "Result Type";
            this.olvColWarningType.Width = 100;
            // 
            // olvColProposedSolution
            // 
            this.olvColProposedSolution.AspectName = "CheckProposedSolution";
            this.olvColProposedSolution.Text = "Proposed solution";
            this.olvColProposedSolution.Width = 400;
            // 
            // olvChecks
            // 
            this.olvChecks.AllColumns.Add(this.olvColCheckDescription);
            this.olvChecks.AllColumns.Add(this.olvColCheckId);
            this.olvChecks.AllColumns.Add(this.olvColCheckStatus);
            this.olvChecks.AllColumns.Add(this.olvColCheckNumberOfElementsFound);
            this.olvChecks.AllColumns.Add(this.olvColCheckNumberOfValidationResults);
            this.olvChecks.AllColumns.Add(this.olvColCheckWarningType);
            this.olvChecks.AllColumns.Add(this.olvColCheckGroup);
            this.olvChecks.AllColumns.Add(this.olvColCheckRationale);
            this.olvChecks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvChecks.CellEditUseWholeCell = false;
            this.olvChecks.CheckedAspectName = "";
            this.olvChecks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColCheckDescription,
            this.olvColCheckId,
            this.olvColCheckStatus,
            this.olvColCheckNumberOfElementsFound,
            this.olvColCheckNumberOfValidationResults,
            this.olvColCheckWarningType,
            this.olvColCheckGroup,
            this.olvColCheckRationale});
            this.olvChecks.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvChecks.Location = new System.Drawing.Point(14, 26);
            this.olvChecks.Name = "olvChecks";
            this.olvChecks.Size = new System.Drawing.Size(971, 207);
            this.olvChecks.TabIndex = 3;
            this.olvChecks.UseCompatibleStateImageBehavior = false;
            this.olvChecks.View = System.Windows.Forms.View.Details;
            this.olvChecks.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvChecks_CellToolTipShowing);
            this.olvChecks.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvChecks_FormatCell);
            this.olvChecks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvChecks_MouseDoubleClick);
            // 
            // olvColCheckDescription
            // 
            this.olvColCheckDescription.AspectName = "CheckDescription";
            this.olvColCheckDescription.HeaderCheckBox = true;
            this.olvColCheckDescription.HeaderCheckState = System.Windows.Forms.CheckState.Checked;
            this.olvColCheckDescription.MaximumWidth = 800;
            this.olvColCheckDescription.MinimumWidth = 50;
            this.olvColCheckDescription.Text = "Description";
            this.olvColCheckDescription.Width = 411;
            // 
            // olvColCheckId
            // 
            this.olvColCheckId.AspectName = "CheckId";
            this.olvColCheckId.AspectToStringFormat = "";
            this.olvColCheckId.MaximumWidth = 200;
            this.olvColCheckId.MinimumWidth = 50;
            this.olvColCheckId.Text = "Id";
            this.olvColCheckId.ToolTipText = "Unique identifier per check";
            this.olvColCheckId.Width = 61;
            // 
            // olvColCheckStatus
            // 
            this.olvColCheckStatus.AspectName = "Status";
            this.olvColCheckStatus.MaximumWidth = 250;
            this.olvColCheckStatus.MinimumWidth = 50;
            this.olvColCheckStatus.Text = "Status";
            this.olvColCheckStatus.ToolTipText = "Check status is not validated, passed or failed";
            this.olvColCheckStatus.Width = 103;
            // 
            // olvColCheckNumberOfElementsFound
            // 
            this.olvColCheckNumberOfElementsFound.AspectName = "NumberOfElementsFound";
            this.olvColCheckNumberOfElementsFound.AspectToStringFormat = "";
            this.olvColCheckNumberOfElementsFound.Text = "# found";
            this.olvColCheckNumberOfElementsFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColCheckNumberOfElementsFound.Width = 80;
            // 
            // olvColCheckNumberOfValidationResults
            // 
            this.olvColCheckNumberOfValidationResults.AspectName = "NumberOfValidationResults";
            this.olvColCheckNumberOfValidationResults.AspectToStringFormat = "";
            this.olvColCheckNumberOfValidationResults.Text = "# results";
            this.olvColCheckNumberOfValidationResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColCheckNumberOfValidationResults.Width = 86;
            // 
            // olvColCheckWarningType
            // 
            this.olvColCheckWarningType.AspectName = "WarningType";
            this.olvColCheckWarningType.Text = "Result Type";
            this.olvColCheckWarningType.Width = 100;
            // 
            // olvColCheckGroup
            // 
            this.olvColCheckGroup.AspectName = "Group";
            this.olvColCheckGroup.Text = "Group";
            this.olvColCheckGroup.Width = 141;
            // 
            // olvColCheckRationale
            // 
            this.olvColCheckRationale.AspectName = "Rationale";
            this.olvColCheckRationale.MaximumWidth = 2048;
            this.olvColCheckRationale.MinimumWidth = 5;
            this.olvColCheckRationale.Text = "Rationale";
            this.olvColCheckRationale.Width = 500;
            // 
            // lblChecks
            // 
            this.lblChecks.AutoSize = true;
            this.lblChecks.Location = new System.Drawing.Point(16, 8);
            this.lblChecks.Name = "lblChecks";
            this.lblChecks.Size = new System.Drawing.Size(95, 13);
            this.lblChecks.TabIndex = 4;
            this.lblChecks.Text = "Checks to validate";
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(17, 350);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(86, 13);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Validation results";
            // 
            // txtElementName
            // 
            this.txtElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElementName.Location = new System.Drawing.Point(83, 24);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.ReadOnly = true;
            this.txtElementName.Size = new System.Drawing.Size(668, 20);
            this.txtElementName.TabIndex = 8;
            // 
            // btnSelectElement
            // 
            this.btnSelectElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectElement.Location = new System.Drawing.Point(758, 22);
            this.btnSelectElement.Name = "btnSelectElement";
            this.btnSelectElement.Size = new System.Drawing.Size(25, 23);
            this.btnSelectElement.TabIndex = 9;
            this.btnSelectElement.Text = "...";
            this.btnSelectElement.UseVisualStyleBackColor = true;
            this.btnSelectElement.Click += new System.EventHandler(this.btnSelectElement_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(14, 324);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(874, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Location = new System.Drawing.Point(20, 27);
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(45, 13);
            this.lblElementName.TabIndex = 16;
            this.lblElementName.Text = "Element";
            // 
            // grpElement
            // 
            this.grpElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpElement.Controls.Add(this.btnClearScope);
            this.grpElement.Controls.Add(this.txtDiagramName);
            this.grpElement.Controls.Add(this.lblDiagram);
            this.grpElement.Controls.Add(this.btnSelectDiagram);
            this.grpElement.Controls.Add(this.btnSelectElement);
            this.grpElement.Controls.Add(this.txtElementName);
            this.grpElement.Controls.Add(this.lblElementName);
            this.grpElement.Location = new System.Drawing.Point(14, 239);
            this.grpElement.Name = "grpElement";
            this.grpElement.Size = new System.Drawing.Size(874, 79);
            this.grpElement.TabIndex = 21;
            this.grpElement.TabStop = false;
            this.grpElement.Text = "Scope";
            // 
            // btnClearScope
            // 
            this.btnClearScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearScope.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearScope.Location = new System.Drawing.Point(789, 48);
            this.btnClearScope.Name = "btnClearScope";
            this.btnClearScope.Size = new System.Drawing.Size(79, 23);
            this.btnClearScope.TabIndex = 29;
            this.btnClearScope.Text = "Clear Scope";
            this.btnClearScope.UseVisualStyleBackColor = true;
            this.btnClearScope.Click += new System.EventHandler(this.btnClearScope_Click);
            // 
            // txtDiagramName
            // 
            this.txtDiagramName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagramName.Location = new System.Drawing.Point(83, 50);
            this.txtDiagramName.Name = "txtDiagramName";
            this.txtDiagramName.ReadOnly = true;
            this.txtDiagramName.Size = new System.Drawing.Size(669, 20);
            this.txtDiagramName.TabIndex = 23;
            // 
            // lblDiagram
            // 
            this.lblDiagram.AutoSize = true;
            this.lblDiagram.Location = new System.Drawing.Point(19, 53);
            this.lblDiagram.Name = "lblDiagram";
            this.lblDiagram.Size = new System.Drawing.Size(46, 13);
            this.lblDiagram.TabIndex = 25;
            this.lblDiagram.Text = "Diagram";
            // 
            // btnSelectDiagram
            // 
            this.btnSelectDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDiagram.Location = new System.Drawing.Point(758, 48);
            this.btnSelectDiagram.Name = "btnSelectDiagram";
            this.btnSelectDiagram.Size = new System.Drawing.Size(25, 23);
            this.btnSelectDiagram.TabIndex = 22;
            this.btnSelectDiagram.Text = "...";
            this.btnSelectDiagram.UseVisualStyleBackColor = true;
            this.btnSelectDiagram.Click += new System.EventHandler(this.btnSelectDiagram_Click);
            // 
            // logoBox
            // 
            this.logoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox.ErrorImage = global::EAValidator.Properties.Resources.EA_Validator_Logo;
            this.logoBox.Image = global::EAValidator.Properties.Resources.EA_Validator_Logo;
            this.logoBox.InitialImage = global::EAValidator.Properties.Resources.EA_Validator_Logo;
            this.logoBox.Location = new System.Drawing.Point(903, 242);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(82, 76);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 13;
            this.logoBox.TabStop = false;
            // 
            // ucEAValidator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblChecks);
            this.Controls.Add(this.olvChecks);
            this.Controls.Add(this.olvValidations);
            this.Controls.Add(this.btnDoValidation);
            this.Controls.Add(this.grpElement);
            this.Name = "ucEAValidator";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.olvValidations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvChecks)).EndInit();
            this.grpElement.ResumeLayout(false);
            this.grpElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoValidation;
        private BrightIdeasSoftware.ObjectListView olvValidations;
        private BrightIdeasSoftware.OLVColumn olvColCheck;
        private BrightIdeasSoftware.OLVColumn olvColItemName;
        private BrightIdeasSoftware.OLVColumn olvColElementType;
        private BrightIdeasSoftware.OLVColumn olvColElementStereotype;
        private BrightIdeasSoftware.OLVColumn olvColPackageName;
        private BrightIdeasSoftware.ObjectListView olvChecks;
        private System.Windows.Forms.Label lblChecks;
        private System.Windows.Forms.Label lblResults;
        private BrightIdeasSoftware.OLVColumn olvColCheckDescription;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Button btnSelectElement;
        private BrightIdeasSoftware.OLVColumn olvColCheckStatus;
        private BrightIdeasSoftware.OLVColumn olvColCheckWarningType;
        private BrightIdeasSoftware.OLVColumn olvColCheckGroup;
        private BrightIdeasSoftware.OLVColumn olvColPackageParentLvl1;
        private BrightIdeasSoftware.OLVColumn olvColPackageParentLvl2;
        private BrightIdeasSoftware.OLVColumn olvColPackageParentLvl3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblElementName;
        private BrightIdeasSoftware.OLVColumn olvColEAItemType;
        private BrightIdeasSoftware.OLVColumn olvColCheckNumberOfElementsFound;
        private BrightIdeasSoftware.OLVColumn olvColCheckNumberOfValidationResults;
        private BrightIdeasSoftware.OLVColumn olvColCheckId;
        private BrightIdeasSoftware.OLVColumn olvColPackageParentLvl4;
        private BrightIdeasSoftware.OLVColumn olvColPackageParentLvl5;
        private System.Windows.Forms.GroupBox grpElement;
        private System.Windows.Forms.Button btnSelectDiagram;
        private System.Windows.Forms.TextBox txtDiagramName;
        private System.Windows.Forms.Label lblDiagram;
        private System.Windows.Forms.Button btnClearScope;
        private BrightIdeasSoftware.OLVColumn olvColWarningType;
        private BrightIdeasSoftware.OLVColumn olvColCheckRationale;
        private BrightIdeasSoftware.OLVColumn olvColProposedSolution;
        private System.Windows.Forms.PictureBox logoBox;
    }
}
