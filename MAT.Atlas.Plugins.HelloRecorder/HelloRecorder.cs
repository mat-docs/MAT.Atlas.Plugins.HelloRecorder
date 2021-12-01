// <copyright file="HelloRecorder.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;

using MAT.Atlas.Api.Core.Diagnostics;
using MAT.Atlas.Api.Recorders;
using MAT.OCS.Core;

namespace MAT.Atlas.Plugins.HelloRecorder
{
    internal class HelloRecorder : RecorderBase
    {
        public HelloRecorder(ILogger logger,
            IRecorderBaseDependencies recorderBaseDependencies)
            : base(logger, recorderBaseDependencies)
        {
        }

        public override bool AutoRecordAvailable => true;

        public override bool AutoRecordEnabled { get; set; }

        public override bool Enabled { get; set; }

        public override bool IsIdle => this.RecorderState == RecorderState.AutoRecordIdle || this.RecorderState == RecorderState.Idle;

        public override bool IsRecording => this.RecorderState == RecorderState.AutoRecording || this.RecorderState == RecorderState.ManualRecording;

        public override bool ManualRecordAvailable => false;

        public override string SessionIdentifierText { get; set; }

        public override SessionKey SessionKey { get; }

        public override IDictionary<string, string> GetSettings()
        {
            return new Dictionary<string, string>
            {
                {
                    "InputSourceIp", "127.0.0.1"
                },
                {
                    "InputSourceMachineName", "USER123"
                },
                {
                    "InputSourcePort", "1234"
                },
            };
        }

        public override void Initialise()
        {
            // called as soon as when ou click on hello recorder entry in session browser
            this.IsInitialised = true;
        }

        public override void SetSQLRaceConnectionString()
        {
        }

        public override void StartRecording()
        {
            //this.SessionKey = new SessionKey(Guid.NewGuid());
        }

        public override bool ValidateConfiguration()
        {
            return true;
        }

        protected override void ForceStopRecorder()
        {
        }

        protected override bool IsBusy()
        {
            return false;
        }

        protected override bool IsRecordStopInProgress()
        {
            return false;
        }

        protected override bool ShutdownRecording(int timeout)
        {
            return true;
        }
    }
}