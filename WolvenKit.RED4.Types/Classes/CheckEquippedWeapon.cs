using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckEquippedWeapon : AIItemHandlingCondition
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public CHandle<AIArgumentMapping> SlotID
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public CHandle<AIArgumentMapping> ItemID
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("slotIDName")] 
		public TweakDBID SlotIDName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("itemIDName")] 
		public TweakDBID ItemIDName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CheckEquippedWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
