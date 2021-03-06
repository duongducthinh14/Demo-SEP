﻿namespace Demo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAccountManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountChange = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgram = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintSyllabus = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintFull = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintReviewProgram = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintReviewSyllabus = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintReviewFull = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusCourseInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusLecturerInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusObjectives = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusOutcomes = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusCourseDescription = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusMethod = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusRequirement = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyllabusMapping = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramCreate = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramCreateSyllabus = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramObjective = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramPlan = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramLecturerList = new DevExpress.XtraBars.BarButtonItem();
            this.btnProgramFacilities = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.pageProgram = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupProgramManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageProgramGeneralInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageSyllabus = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupSyllabusInfo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupSyllabusSchedule = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupSyllabusObjectiveOutcome = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupSyllabusMapping = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagePrint = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupPrintReview = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageAccount = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupAccountManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupAccountPassword = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAccountManager,
            this.btnAccountReset,
            this.btnAccountChange,
            this.btnProgram,
            this.btnPrintSyllabus,
            this.btnPrintFull,
            this.btnPrintReviewProgram,
            this.btnPrintReviewSyllabus,
            this.btnPrintReviewFull,
            this.btnSyllabusCourseInfo,
            this.btnSyllabusLecturerInfo,
            this.btnSyllabusObjectives,
            this.btnSyllabusOutcomes,
            this.btnSyllabusCourseDescription,
            this.btnSyllabusDocument,
            this.btnSyllabusMethod,
            this.btnSyllabusRequirement,
            this.btnSyllabusSchedule,
            this.btnSyllabusMapping,
            this.btnProgramCreate,
            this.btnProgramCreateSyllabus,
            this.btnProgramInfo,
            this.btnProgramObjective,
            this.btnProgramPlan,
            this.btnProgramLecturerList,
            this.btnProgramFacilities,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 36;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageProgram,
            this.pageSyllabus,
            this.pagePrint,
            this.pageAccount});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(976, 166);
            // 
            // btnAccountManager
            // 
            this.btnAccountManager.Caption = "Quản Lý Tài khoản";
            this.btnAccountManager.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAccountManager.Glyph")));
            this.btnAccountManager.Id = 1;
            this.btnAccountManager.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAccountManager.LargeGlyph")));
            this.btnAccountManager.LargeWidth = 75;
            this.btnAccountManager.Name = "btnAccountManager";
            // 
            // btnAccountReset
            // 
            this.btnAccountReset.Caption = "Đặt Lại Mật Khẩu";
            this.btnAccountReset.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAccountReset.Glyph")));
            this.btnAccountReset.Id = 3;
            this.btnAccountReset.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAccountReset.LargeGlyph")));
            this.btnAccountReset.LargeWidth = 75;
            this.btnAccountReset.Name = "btnAccountReset";
            // 
            // btnAccountChange
            // 
            this.btnAccountChange.Caption = "Đổi Mật Khẩu";
            this.btnAccountChange.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAccountChange.Glyph")));
            this.btnAccountChange.Id = 4;
            this.btnAccountChange.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAccountChange.LargeGlyph")));
            this.btnAccountChange.LargeWidth = 75;
            this.btnAccountChange.Name = "btnAccountChange";
            // 
            // btnProgram
            // 
            this.btnProgram.Caption = "In Chương Trình Đào Tạo";
            this.btnProgram.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgram.Glyph")));
            this.btnProgram.Id = 6;
            this.btnProgram.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgram.LargeGlyph")));
            this.btnProgram.LargeWidth = 90;
            this.btnProgram.Name = "btnProgram";
            // 
            // btnPrintSyllabus
            // 
            this.btnPrintSyllabus.Caption = "In Đề Cương Môn Học";
            this.btnPrintSyllabus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintSyllabus.Glyph")));
            this.btnPrintSyllabus.Id = 7;
            this.btnPrintSyllabus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrintSyllabus.LargeGlyph")));
            this.btnPrintSyllabus.LargeWidth = 90;
            this.btnPrintSyllabus.Name = "btnPrintSyllabus";
            // 
            // btnPrintFull
            // 
            this.btnPrintFull.Caption = "In Toàn Bộ Chương Trình";
            this.btnPrintFull.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintFull.Glyph")));
            this.btnPrintFull.Id = 8;
            this.btnPrintFull.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrintFull.LargeGlyph")));
            this.btnPrintFull.LargeWidth = 90;
            this.btnPrintFull.Name = "btnPrintFull";
            // 
            // btnPrintReviewProgram
            // 
            this.btnPrintReviewProgram.Caption = "Xem Lại Chương Trình Đào Tạo";
            this.btnPrintReviewProgram.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewProgram.Glyph")));
            this.btnPrintReviewProgram.Id = 9;
            this.btnPrintReviewProgram.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewProgram.LargeGlyph")));
            this.btnPrintReviewProgram.LargeWidth = 90;
            this.btnPrintReviewProgram.Name = "btnPrintReviewProgram";
            // 
            // btnPrintReviewSyllabus
            // 
            this.btnPrintReviewSyllabus.Caption = "Xem Lại Đề Cương Môn Học";
            this.btnPrintReviewSyllabus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewSyllabus.Glyph")));
            this.btnPrintReviewSyllabus.Id = 10;
            this.btnPrintReviewSyllabus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewSyllabus.LargeGlyph")));
            this.btnPrintReviewSyllabus.LargeWidth = 90;
            this.btnPrintReviewSyllabus.Name = "btnPrintReviewSyllabus";
            // 
            // btnPrintReviewFull
            // 
            this.btnPrintReviewFull.Caption = "Xem Lại Toàn Bộ";
            this.btnPrintReviewFull.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewFull.Glyph")));
            this.btnPrintReviewFull.Id = 11;
            this.btnPrintReviewFull.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrintReviewFull.LargeGlyph")));
            this.btnPrintReviewFull.LargeWidth = 90;
            this.btnPrintReviewFull.Name = "btnPrintReviewFull";
            // 
            // btnSyllabusCourseInfo
            // 
            this.btnSyllabusCourseInfo.Caption = "Thông Tin Môn Học";
            this.btnSyllabusCourseInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCourseInfo.Glyph")));
            this.btnSyllabusCourseInfo.Id = 12;
            this.btnSyllabusCourseInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCourseInfo.LargeGlyph")));
            this.btnSyllabusCourseInfo.LargeWidth = 75;
            this.btnSyllabusCourseInfo.Name = "btnSyllabusCourseInfo";
            // 
            // btnSyllabusLecturerInfo
            // 
            this.btnSyllabusLecturerInfo.Caption = "Thông Tin Giảng Viên";
            this.btnSyllabusLecturerInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusLecturerInfo.Glyph")));
            this.btnSyllabusLecturerInfo.Id = 13;
            this.btnSyllabusLecturerInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusLecturerInfo.LargeGlyph")));
            this.btnSyllabusLecturerInfo.LargeWidth = 75;
            this.btnSyllabusLecturerInfo.Name = "btnSyllabusLecturerInfo";
            // 
            // btnSyllabusObjectives
            // 
            this.btnSyllabusObjectives.Caption = "Mục Tiêu";
            this.btnSyllabusObjectives.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusObjectives.Glyph")));
            this.btnSyllabusObjectives.Id = 15;
            this.btnSyllabusObjectives.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusObjectives.LargeGlyph")));
            this.btnSyllabusObjectives.LargeWidth = 75;
            this.btnSyllabusObjectives.Name = "btnSyllabusObjectives";
            // 
            // btnSyllabusOutcomes
            // 
            this.btnSyllabusOutcomes.Caption = "Đầu Ra";
            this.btnSyllabusOutcomes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusOutcomes.Glyph")));
            this.btnSyllabusOutcomes.Id = 16;
            this.btnSyllabusOutcomes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusOutcomes.LargeGlyph")));
            this.btnSyllabusOutcomes.LargeWidth = 75;
            this.btnSyllabusOutcomes.Name = "btnSyllabusOutcomes";
            // 
            // btnSyllabusCourseDescription
            // 
            this.btnSyllabusCourseDescription.Caption = "Mô Tả Vắn Tắt";
            this.btnSyllabusCourseDescription.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCourseDescription.Glyph")));
            this.btnSyllabusCourseDescription.Id = 17;
            this.btnSyllabusCourseDescription.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCourseDescription.LargeGlyph")));
            this.btnSyllabusCourseDescription.LargeWidth = 75;
            this.btnSyllabusCourseDescription.Name = "btnSyllabusCourseDescription";
            // 
            // btnSyllabusDocument
            // 
            this.btnSyllabusDocument.Caption = "Thông Tin Tài Liệu";
            this.btnSyllabusDocument.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusDocument.Glyph")));
            this.btnSyllabusDocument.Id = 18;
            this.btnSyllabusDocument.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusDocument.LargeGlyph")));
            this.btnSyllabusDocument.LargeWidth = 75;
            this.btnSyllabusDocument.Name = "btnSyllabusDocument";
            // 
            // btnSyllabusMethod
            // 
            this.btnSyllabusMethod.Caption = "Phương Pháp Đánh Giá";
            this.btnSyllabusMethod.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusMethod.Glyph")));
            this.btnSyllabusMethod.Id = 19;
            this.btnSyllabusMethod.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusMethod.LargeGlyph")));
            this.btnSyllabusMethod.LargeWidth = 75;
            this.btnSyllabusMethod.Name = "btnSyllabusMethod";
            // 
            // btnSyllabusRequirement
            // 
            this.btnSyllabusRequirement.Caption = "Yêu Cầu Môn Học";
            this.btnSyllabusRequirement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusRequirement.Glyph")));
            this.btnSyllabusRequirement.Id = 20;
            this.btnSyllabusRequirement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusRequirement.LargeGlyph")));
            this.btnSyllabusRequirement.LargeWidth = 75;
            this.btnSyllabusRequirement.Name = "btnSyllabusRequirement";
            // 
            // btnSyllabusSchedule
            // 
            this.btnSyllabusSchedule.Caption = "Lịch Biểu";
            this.btnSyllabusSchedule.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusSchedule.Glyph")));
            this.btnSyllabusSchedule.Id = 21;
            this.btnSyllabusSchedule.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusSchedule.LargeGlyph")));
            this.btnSyllabusSchedule.LargeWidth = 75;
            this.btnSyllabusSchedule.Name = "btnSyllabusSchedule";
            // 
            // btnSyllabusMapping
            // 
            this.btnSyllabusMapping.Caption = "Liên Kết Đầu Ra";
            this.btnSyllabusMapping.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusMapping.Glyph")));
            this.btnSyllabusMapping.Id = 22;
            this.btnSyllabusMapping.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSyllabusMapping.LargeGlyph")));
            this.btnSyllabusMapping.LargeWidth = 75;
            this.btnSyllabusMapping.Name = "btnSyllabusMapping";
            // 
            // btnProgramCreate
            // 
            this.btnProgramCreate.Caption = "Tạo Chương Trình";
            this.btnProgramCreate.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramCreate.Glyph")));
            this.btnProgramCreate.Id = 24;
            this.btnProgramCreate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramCreate.LargeGlyph")));
            this.btnProgramCreate.LargeWidth = 75;
            this.btnProgramCreate.Name = "btnProgramCreate";
            // 
            // btnProgramCreateSyllabus
            // 
            this.btnProgramCreateSyllabus.Caption = "Phân Công Môn Học";
            this.btnProgramCreateSyllabus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramCreateSyllabus.Glyph")));
            this.btnProgramCreateSyllabus.Id = 25;
            this.btnProgramCreateSyllabus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramCreateSyllabus.LargeGlyph")));
            this.btnProgramCreateSyllabus.LargeWidth = 75;
            this.btnProgramCreateSyllabus.Name = "btnProgramCreateSyllabus";
            // 
            // btnProgramInfo
            // 
            this.btnProgramInfo.Caption = "Thông Tin Chương Trình";
            this.btnProgramInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramInfo.Glyph")));
            this.btnProgramInfo.Id = 26;
            this.btnProgramInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramInfo.LargeGlyph")));
            this.btnProgramInfo.LargeWidth = 90;
            this.btnProgramInfo.Name = "btnProgramInfo";
            // 
            // btnProgramObjective
            // 
            this.btnProgramObjective.Caption = "Mục Tiêu";
            this.btnProgramObjective.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramObjective.Glyph")));
            this.btnProgramObjective.Id = 27;
            this.btnProgramObjective.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramObjective.LargeGlyph")));
            this.btnProgramObjective.LargeWidth = 75;
            this.btnProgramObjective.Name = "btnProgramObjective";
            // 
            // btnProgramPlan
            // 
            this.btnProgramPlan.Caption = "Kế Hoạch Giảng Dạy";
            this.btnProgramPlan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramPlan.Glyph")));
            this.btnProgramPlan.Id = 30;
            this.btnProgramPlan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramPlan.LargeGlyph")));
            this.btnProgramPlan.LargeWidth = 90;
            this.btnProgramPlan.Name = "btnProgramPlan";
            // 
            // btnProgramLecturerList
            // 
            this.btnProgramLecturerList.Caption = "Danh Sách Giảng Viên";
            this.btnProgramLecturerList.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramLecturerList.Glyph")));
            this.btnProgramLecturerList.Id = 32;
            this.btnProgramLecturerList.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramLecturerList.LargeGlyph")));
            this.btnProgramLecturerList.LargeWidth = 90;
            this.btnProgramLecturerList.Name = "btnProgramLecturerList";
            // 
            // btnProgramFacilities
            // 
            this.btnProgramFacilities.Caption = "Thông Tin Cơ Sở Vật Chất";
            this.btnProgramFacilities.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProgramFacilities.Glyph")));
            this.btnProgramFacilities.Id = 33;
            this.btnProgramFacilities.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProgramFacilities.LargeGlyph")));
            this.btnProgramFacilities.LargeWidth = 90;
            this.btnProgramFacilities.Name = "btnProgramFacilities";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            // 
            // 
            // 
            this.skinRibbonGalleryBarItem1.Gallery.ShowItemText = true;
            this.skinRibbonGalleryBarItem1.Id = 34;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // pageProgram
            // 
            this.pageProgram.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupProgramManager,
            this.pageProgramGeneralInfo});
            this.pageProgram.Name = "pageProgram";
            this.pageProgram.Text = "Chương Trình Đào Tạo";
            // 
            // groupProgramManager
            // 
            this.groupProgramManager.ItemLinks.Add(this.btnProgramCreate);
            this.groupProgramManager.ItemLinks.Add(this.btnProgramCreateSyllabus);
            this.groupProgramManager.Name = "groupProgramManager";
            this.groupProgramManager.Text = "Quản Lý Chương Trình";
            // 
            // pageProgramGeneralInfo
            // 
            this.pageProgramGeneralInfo.ItemLinks.Add(this.btnProgramInfo);
            this.pageProgramGeneralInfo.ItemLinks.Add(this.btnProgramPlan);
            this.pageProgramGeneralInfo.ItemLinks.Add(this.btnProgramLecturerList);
            this.pageProgramGeneralInfo.ItemLinks.Add(this.btnProgramFacilities);
            this.pageProgramGeneralInfo.Name = "pageProgramGeneralInfo";
            this.pageProgramGeneralInfo.Text = "Thông Tin Chung";
            // 
            // pageSyllabus
            // 
            this.pageSyllabus.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupSyllabusInfo,
            this.groupSyllabusSchedule,
            this.groupSyllabusObjectiveOutcome,
            this.groupSyllabusMapping});
            this.pageSyllabus.Name = "pageSyllabus";
            this.pageSyllabus.Text = "Đề Cương";
            // 
            // groupSyllabusInfo
            // 
            this.groupSyllabusInfo.ItemLinks.Add(this.btnSyllabusCourseInfo);
            this.groupSyllabusInfo.ItemLinks.Add(this.btnSyllabusLecturerInfo);
            this.groupSyllabusInfo.ItemLinks.Add(this.btnSyllabusCourseDescription);
            this.groupSyllabusInfo.ItemLinks.Add(this.btnSyllabusDocument);
            this.groupSyllabusInfo.ItemLinks.Add(this.btnSyllabusRequirement);
            this.groupSyllabusInfo.Name = "groupSyllabusInfo";
            this.groupSyllabusInfo.Text = "Thông Tin Chung";
            // 
            // groupSyllabusSchedule
            // 
            this.groupSyllabusSchedule.ItemLinks.Add(this.btnSyllabusSchedule);
            this.groupSyllabusSchedule.Name = "groupSyllabusSchedule";
            this.groupSyllabusSchedule.Text = "Kế Hoạch";
            // 
            // groupSyllabusObjectiveOutcome
            // 
            this.groupSyllabusObjectiveOutcome.ItemLinks.Add(this.btnSyllabusObjectives);
            this.groupSyllabusObjectiveOutcome.ItemLinks.Add(this.btnSyllabusOutcomes);
            this.groupSyllabusObjectiveOutcome.Name = "groupSyllabusObjectiveOutcome";
            this.groupSyllabusObjectiveOutcome.Text = "Mục Tiêu Và Đầu Ra";
            // 
            // groupSyllabusMapping
            // 
            this.groupSyllabusMapping.ItemLinks.Add(this.btnSyllabusMapping);
            this.groupSyllabusMapping.ItemLinks.Add(this.btnSyllabusMethod);
            this.groupSyllabusMapping.Name = "groupSyllabusMapping";
            this.groupSyllabusMapping.Text = "Liên Kết";
            // 
            // pagePrint
            // 
            this.pagePrint.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupPrint,
            this.groupPrintReview});
            this.pagePrint.Name = "pagePrint";
            this.pagePrint.Text = "Xem Lại và In";
            // 
            // groupPrint
            // 
            this.groupPrint.ItemLinks.Add(this.btnProgram);
            this.groupPrint.ItemLinks.Add(this.btnPrintSyllabus);
            this.groupPrint.ItemLinks.Add(this.btnPrintFull);
            this.groupPrint.Name = "groupPrint";
            this.groupPrint.Text = "In";
            // 
            // groupPrintReview
            // 
            this.groupPrintReview.ItemLinks.Add(this.btnPrintReviewProgram);
            this.groupPrintReview.ItemLinks.Add(this.btnPrintReviewSyllabus);
            this.groupPrintReview.ItemLinks.Add(this.btnPrintReviewFull);
            this.groupPrintReview.Name = "groupPrintReview";
            this.groupPrintReview.Text = "Xem Lại";
            // 
            // pageAccount
            // 
            this.pageAccount.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupAccountManager,
            this.groupAccountPassword});
            this.pageAccount.Name = "pageAccount";
            this.pageAccount.Text = "Tài Khoản";
            // 
            // groupAccountManager
            // 
            this.groupAccountManager.ItemLinks.Add(this.btnAccountManager);
            this.groupAccountManager.Name = "groupAccountManager";
            this.groupAccountManager.Text = "Quản Lý";
            // 
            // groupAccountPassword
            // 
            this.groupAccountPassword.ItemLinks.Add(this.btnAccountReset);
            this.groupAccountPassword.ItemLinks.Add(this.btnAccountChange);
            this.groupAccountPassword.Name = "groupAccountPassword";
            this.groupAccountPassword.Text = "Mật Khẩu";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 521);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Education Program Builder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupAccountManager;
        private DevExpress.XtraBars.BarButtonItem btnAccountManager;
        private DevExpress.XtraBars.BarButtonItem btnAccountReset;
        private DevExpress.XtraBars.BarButtonItem btnAccountChange;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupAccountPassword;
        private DevExpress.XtraBars.BarButtonItem btnProgram;
        private DevExpress.XtraBars.BarButtonItem btnPrintSyllabus;
        private DevExpress.XtraBars.BarButtonItem btnPrintFull;
        private DevExpress.XtraBars.Ribbon.RibbonPage pagePrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupPrint;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupPrintReview;
        private DevExpress.XtraBars.BarButtonItem btnPrintReviewProgram;
        private DevExpress.XtraBars.BarButtonItem btnPrintReviewSyllabus;
        private DevExpress.XtraBars.BarButtonItem btnPrintReviewFull;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageSyllabus;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSyllabusInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSyllabusObjectiveOutcome;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusCourseInfo;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusLecturerInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSyllabusSchedule;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSyllabusMapping;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusObjectives;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusOutcomes;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusCourseDescription;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusDocument;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusMethod;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusRequirement;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusSchedule;
        private DevExpress.XtraBars.BarButtonItem btnSyllabusMapping;
        private DevExpress.XtraBars.BarButtonItem btnProgramCreate;
        private DevExpress.XtraBars.BarButtonItem btnProgramCreateSyllabus;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageProgram;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupProgramManager;
        private DevExpress.XtraBars.BarButtonItem btnProgramInfo;
        private DevExpress.XtraBars.BarButtonItem btnProgramObjective;
        private DevExpress.XtraBars.BarButtonItem btnProgramPlan;
        private DevExpress.XtraBars.BarButtonItem btnProgramLecturerList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageProgramGeneralInfo;
        private DevExpress.XtraBars.BarButtonItem btnProgramFacilities;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

