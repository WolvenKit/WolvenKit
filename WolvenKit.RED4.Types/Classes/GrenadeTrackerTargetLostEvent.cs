using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeTrackerTargetLostEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<ScriptedPuppet> Target
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
