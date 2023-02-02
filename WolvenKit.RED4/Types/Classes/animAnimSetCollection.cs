using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSetCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animSets")] 
		public CArray<CResourceAsyncReference<animAnimSet>> AnimSets
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<animAnimSet>>>(value);
		}

		[Ordinal(1)] 
		[RED("overrideAnimSets")] 
		public CArray<animOverrideAnimSetRef> OverrideAnimSets
		{
			get => GetPropertyValue<CArray<animOverrideAnimSetRef>>();
			set => SetPropertyValue<CArray<animOverrideAnimSetRef>>(value);
		}

		[Ordinal(2)] 
		[RED("animWrapperVariables")] 
		public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables
		{
			get => GetPropertyValue<CArray<animAnimWrapperVariableDescription>>();
			set => SetPropertyValue<CArray<animAnimWrapperVariableDescription>>(value);
		}

		public animAnimSetCollection()
		{
			AnimSets = new();
			OverrideAnimSets = new();
			AnimWrapperVariables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
