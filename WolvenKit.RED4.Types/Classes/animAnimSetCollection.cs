using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSetCollection : RedBaseClass
	{
		private CArray<CResourceAsyncReference<animAnimSet>> _animSets;
		private CArray<animOverrideAnimSetRef> _overrideAnimSets;
		private CArray<animAnimWrapperVariableDescription> _animWrapperVariables;

		[Ordinal(0)] 
		[RED("animSets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(1)] 
		[RED("overrideAnimSets")] 
		public CArray<animOverrideAnimSetRef> OverrideAnimSets
		{
			get => GetProperty(ref _overrideAnimSets);
			set => SetProperty(ref _overrideAnimSets, value);
		}

		[Ordinal(2)] 
		[RED("animWrapperVariables")] 
		public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables
		{
			get => GetProperty(ref _animWrapperVariables);
			set => SetProperty(ref _animWrapperVariables, value);
		}
	}
}
