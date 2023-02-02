
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNPCEquipmentItem_Record
	{
		[RED("equipCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("equipSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EquipSlot
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
		
		[RED("onBodySlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OnBodySlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("unequipCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> UnequipCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
