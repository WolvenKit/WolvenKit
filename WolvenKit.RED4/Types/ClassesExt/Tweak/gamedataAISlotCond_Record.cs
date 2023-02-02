
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISlotCond_Record
	{
		[RED("checkIfEmptySlotIsSpawningItem")]
		[REDProperty(IsIgnored = true)]
		public CInt32 CheckIfEmptySlotIsSpawningItem
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("requestedTriggerModes")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RequestedTriggerModes
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
