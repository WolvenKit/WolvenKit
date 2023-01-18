using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSetupEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("animSet")] 
		public CResourceAsyncReference<animAnimSet> AnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		[Ordinal(2)] 
		[RED("variableNames")] 
		public CArray<CName> VariableNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public animAnimSetupEntry()
		{
			Priority = 128;
			VariableNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
