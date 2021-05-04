using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCSharedDataDefinition : CVariable
	{
		private CArray<CString> _defaultChoices;
		private CHandle<gameuiIChoiceVisualizer> _visualizer;

		[Ordinal(0)] 
		[RED("defaultChoices")] 
		public CArray<CString> DefaultChoices
		{
			get => GetProperty(ref _defaultChoices);
			set => SetProperty(ref _defaultChoices, value);
		}

		[Ordinal(1)] 
		[RED("visualizer")] 
		public CHandle<gameuiIChoiceVisualizer> Visualizer
		{
			get => GetProperty(ref _visualizer);
			set => SetProperty(ref _visualizer, value);
		}

		public gameinteractionsCSharedDataDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
