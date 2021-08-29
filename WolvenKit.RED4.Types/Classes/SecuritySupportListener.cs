using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySupportListener : AIScriptsTargetTrackingListener
	{
		private CWeakHandle<ScriptedPuppet> _npc;

		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<ScriptedPuppet> Npc
		{
			get => GetProperty(ref _npc);
			set => SetProperty(ref _npc, value);
		}
	}
}
