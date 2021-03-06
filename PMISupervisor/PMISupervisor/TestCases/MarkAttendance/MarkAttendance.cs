﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PMISupervisor.TestCases.MarkAttendance
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MarkAttendance recording.
    /// </summary>
    [TestModule("6a1409c8-9702-4269-92ca-0bdc6f4b2078", ModuleType.Recording, 1)]
    public partial class MarkAttendance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMISupervisor.PMISupervisorRepository repository.
        /// </summary>
        public static PMISupervisor.PMISupervisorRepository repo = PMISupervisor.PMISupervisorRepository.Instance;

        static MarkAttendance instance = new MarkAttendance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MarkAttendance()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MarkAttendance Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.ButtonSubmit' at Center", repo.PMI_Supervisor.ButtonSubmitInfo, new RecordItemIndex(0));
            repo.PMI_Supervisor.ButtonSubmit.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PMI_Supervisor.Validation_OKButton'.", repo.PMI_Supervisor.Validation_OKButtonInfo, new RecordItemIndex(1));
            Validate.Exists(repo.PMI_Supervisor.Validation_OKButtonInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.Validation_OKButton' at Center", repo.PMI_Supervisor.Validation_OKButtonInfo, new RecordItemIndex(2));
            repo.PMI_Supervisor.Validation_OKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PMI_Supervisor.Attendance_Button' at Center", repo.PMI_Supervisor.Attendance_ButtonInfo, new RecordItemIndex(3));
            repo.PMI_Supervisor.Attendance_Button.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Attendance') on item 'PMI_Supervisor.Validate_AttendanceScreen'.", repo.PMI_Supervisor.Validate_AttendanceScreenInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.PMI_Supervisor.Validate_AttendanceScreenInfo, "Text", "Attendance");
            Delay.Milliseconds(0);
            
            UserCode.UserCode.markMerchandiserAttendance();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
