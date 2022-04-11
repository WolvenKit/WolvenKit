using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCGodModeListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}
	}
}
