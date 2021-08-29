using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSequence : IScriptable
	{
		private CName _name;
		private CArray<CHandle<inkanimDefinition>> _definitions;
		private CArray<CHandle<inkanimSequenceTargetInfo>> _targets;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("definitions")] 
		public CArray<CHandle<inkanimDefinition>> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<CHandle<inkanimSequenceTargetInfo>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}
	}
}
