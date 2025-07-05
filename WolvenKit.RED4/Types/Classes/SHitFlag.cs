using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SHitFlag : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SHitFlag()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
