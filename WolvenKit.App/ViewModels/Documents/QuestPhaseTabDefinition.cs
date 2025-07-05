using System;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Documents
{
    public class QuestPhaseTabDefinition
    {
        public string Header { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public Func<ChunkViewModel, bool> Filter { get; set; } = _ => false;
    }
} 