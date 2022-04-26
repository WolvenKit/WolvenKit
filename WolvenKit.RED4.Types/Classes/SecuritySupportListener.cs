using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySupportListener : AIScriptsTargetTrackingListener
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<ScriptedPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		public SecuritySupportListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
