using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnMonowireQuickhackContagiousTargetStatusAppliedCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("ContagiousTarget")] 
		public CWeakHandle<ScriptedPuppet> ContagiousTarget
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		public OnMonowireQuickhackContagiousTargetStatusAppliedCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
