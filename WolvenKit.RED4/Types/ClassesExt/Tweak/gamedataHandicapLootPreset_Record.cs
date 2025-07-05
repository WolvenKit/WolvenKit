
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHandicapLootPreset_Record
	{
		[RED("handicapLimit")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HandicapLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("handicapMaxQty")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HandicapMaxQty
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("handicapMinQty")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HandicapMinQty
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
