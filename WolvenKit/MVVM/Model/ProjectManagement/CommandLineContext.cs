// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandLineContext.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WolvenKit.MVVM.Model.ProjectManagement
{
    using Orc.CommandLine;

    public class CommandLineContext : ContextBase
    {
        [Option("", "", DisplayName = "initialFile", HelpText = "The initial project open in WolvenKit")]
        public string InitialFile { get; set; }
    }
}
