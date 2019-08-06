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

namespace PreEmp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("cef627bc-04d2-452b-aef9-26db1bc27b68", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PreEmpRepository repository.
        /// </summary>
        public static PreEmpRepository repo = PreEmpRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'Calculator'.", repo.Calculator.SelfInfo, new RecordItemIndex(0));
            repo.Calculator.Self.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Maximize' at Center.", repo.Calculator.MaximizeInfo, new RecordItemIndex(1));
            repo.Calculator.Maximize.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "checking sum", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at Center.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(3));
            repo.Calculator.NumberPad.Num1Button.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.PlusButton' at Center.", repo.Calculator.PlusButtonInfo, new RecordItemIndex(4));
            repo.Calculator.PlusButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num2Button' at Center.", repo.Calculator.NumberPad.Num2ButtonInfo, new RecordItemIndex(5));
            repo.Calculator.NumberPad.Num2Button.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at Center.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(6));
            repo.Calculator.EqualButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "sum result", repo.Calculator.NormalOutput, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='‭3‬') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Text", "‭3‬", null, new Validate.Options(){ReportLevelOnFailure=ReportLevel.Debug, ReportLevelOnSuccess=ReportLevel.Debug, ReportScreenshot=Validate.ResultOption.Always});
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", "checking multiplication", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Text7' at Center.", repo.Calculator.Text7Info, new RecordItemIndex(11));
            repo.Calculator.Text7.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.MultiplyButton' at Center.", repo.Calculator.MultiplyButtonInfo, new RecordItemIndex(12));
            repo.Calculator.MultiplyButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Text5' at Center.", repo.Calculator.Text5Info, new RecordItemIndex(13));
            repo.Calculator.Text5.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at Center.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(14));
            repo.Calculator.EqualButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='‭35‬') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Text", "‭35‬");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", "checking square root", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num9Button' at Center.", repo.Calculator.NumberPad.Num9ButtonInfo, new RecordItemIndex(19));
            repo.Calculator.NumberPad.Num9Button.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.SquareRootButton' at Center.", repo.Calculator.SquareRootButtonInfo, new RecordItemIndex(20));
            repo.Calculator.SquareRootButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.ClearButton' at Center.", repo.Calculator.ClearButtonInfo, new RecordItemIndex(21));
            repo.Calculator.ClearButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='‭0‬') on item 'Calculator.NormalOutput'.", repo.Calculator.NormalOutputInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.Calculator.NormalOutputInfo, "Text", "‭0‬");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Icon' at Center.", repo.Calculator.IconInfo, new RecordItemIndex(24));
            repo.Calculator.Icon.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Programmer' at Center.", repo.Calculator.ProgrammerInfo, new RecordItemIndex(25));
            repo.Calculator.Programmer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'Calculator.Header'.", repo.Calculator.HeaderInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.Calculator.HeaderInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Caption='Programmer Calculator mode') on item 'Calculator.Header'.", repo.Calculator.HeaderInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.Calculator.HeaderInfo, "Caption", "Programmer Calculator mode");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Programmer') on item 'Calculator.Header'.", repo.Calculator.HeaderInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.Calculator.HeaderInfo, "Text", "Programmer");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
