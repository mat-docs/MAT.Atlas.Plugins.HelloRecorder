// <copyright file="HelloRecorderViewModel.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using MAT.Atlas.Api.Core.Diagnostics;
using MAT.Atlas.Api.Core.Signals;
using MAT.Atlas.Api.Presentation;
using MAT.Atlas.Api.Presentation.ViewModels;
using MAT.Atlas.Api.Recorders;

namespace MAT.Atlas.Plugins.HelloRecorder
{
    public class HelloRecorderViewModel : RecorderViewModelBase
    {
        public HelloRecorderViewModel(ISignalBus signalBus, ILogger logger, IRecorder recorder, ISqlRaceConfigurationViewModel sqlRaceConfigurationViewModel, IDispatcherSchedulerProvider schedulerProvider)
            : base(signalBus, logger, recorder, sqlRaceConfigurationViewModel, schedulerProvider)
        {
            this.Refreshing = false;
        }

        protected override void RefreshRecorderDetails()
        {
        }

        protected override void SubscribeToRecorderEvents()
        {
        }

        protected override void UnsubscribeFromRecorderEvents()
        {
        }
    }
}