using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeTrackerTargetAcquiredEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<ScriptedPuppet> Target
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
