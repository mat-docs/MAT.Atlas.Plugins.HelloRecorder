// <copyright file="PluginModule.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.ComponentModel.Composition;

using Autofac;
using Autofac.Core;

using MAT.Atlas.Api.Core.Autofac;
using MAT.Atlas.Api.Plugins;

namespace MAT.Atlas.Plugins.HelloRecorder
{
    [Export(typeof(IModule))]
    public sealed class PluginModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Plugin, IAtlasRecorderPlugin>();

            //builder.RegisterType<MyDep1, IMyDep1>();
            //builder.RegisterSingleInstance<MyDep2, IMyDep2>();
        }
    }
}