using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("set")] 
		public CResourceReference<gameEffectSet> Set
		{
			get => GetPropertyValue<CResourceReference<gameEffectSet>>();
			set => SetPropertyValue<CResourceReference<gameEffectSet>>(value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
