using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrideType")] 
		public CEnum<inkStyleOverrideType> OverrideType
		{
			get => GetPropertyValue<CEnum<inkStyleOverrideType>>();
			set => SetPropertyValue<CEnum<inkStyleOverrideType>>(value);
		}

		[Ordinal(1)] 
		[RED("styleResource")] 
		public CResourceReference<inkStyleResource> StyleResource
		{
			get => GetPropertyValue<CResourceReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceReference<inkStyleResource>>(value);
		}

		public inkStyleOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
