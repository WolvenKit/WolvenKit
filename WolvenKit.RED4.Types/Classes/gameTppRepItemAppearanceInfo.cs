using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTppRepItemAppearanceInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
