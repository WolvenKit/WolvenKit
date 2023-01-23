using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTppRepAttachedObjectInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameTppRepAttachedObjectInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
