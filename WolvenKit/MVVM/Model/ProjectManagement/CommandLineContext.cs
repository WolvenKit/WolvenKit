// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandLineContext.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using Orc.CommandLine;

namespace WolvenKit.MVVM.Model.ProjectManagement
{
    public class CommandLineContext : ContextBase
    {
        #region Properties

        [Option("", "", DisplayName = "initialFile", HelpText = "The initial project open in WolvenKit")]
        public string InitialFile { get; set; }

        #endregion Properties
    }
}
