using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySupportListener : AIScriptsTargetTrackingListener
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<ScriptedPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
