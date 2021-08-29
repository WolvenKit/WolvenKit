using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animOverrideAnimSetRef : RedBaseClass
	{
		private CResourceAsyncReference<animAnimSet> _animSet;
		private CName _variableName;

		[Ordinal(0)] 
		[RED("animSet")] 
		public CResourceAsyncReference<animAnimSet> AnimSet
		{
			get => GetProperty(ref _animSet);
			set => SetProperty(ref _animSet, value);
		}

		[Ordinal(1)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}
	}
}
