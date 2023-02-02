
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInventoryItem_Record
	{
		[RED("activeForSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActiveForSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("chanceInCrowd")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChanceInCrowd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("equipSlot_DEPRECATED")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EquipSlot_DEPRECATED
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("quantity")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
