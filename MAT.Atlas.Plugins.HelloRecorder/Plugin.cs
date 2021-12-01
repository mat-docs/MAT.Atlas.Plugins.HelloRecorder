// <copyright file="Plugin.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System;

using MAT.Atlas.Api;
using MAT.Atlas.Api.Plugins;
using MAT.Atlas.Api.Presentation.Recorders;
using MAT.Atlas.Api.Recorders;

namespace MAT.Atlas.Plugins.HelloRecorder
{
    internal sealed class Plugin : AtlasAssemblyPluginBase, IAtlasRecorderPlugin
    {
        private const string ShortName = "HLO"; //must be 3 characters long
        private const string RecorderName = "Hello Recorder";
        private static readonly Guid UniqueId = new Guid("089e3f11-1f93-4836-baaa-ce6d2094e39f");

        private readonly IRecordersService recordersService;
        private readonly IRecorderEditorService recorderEditorService;

        public Plugin(
            IPluginVersion pluginVersion,
            IAssemblyInfoProvider assemblyInfoProvider,
            IRecordersService recordersService,
            IRecorderEditorService recorderEditorService)
            : base(pluginVersion, assemblyInfoProvider)
        {
            this.recordersService = recordersService;
            this.recorderEditorService = recorderEditorService;
        }

        public override void Initialise()
        {
            // Register recorder
            this.recordersService.Register<HelloRecorder>(UniqueId, RecorderName);
            this.recorderEditorService.Register<HelloRecorderView, HelloRecorderViewModel>(UniqueId, ShortName);
        }
    }
}