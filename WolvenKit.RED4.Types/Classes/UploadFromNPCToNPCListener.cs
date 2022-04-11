using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		[Ordinal(2)] 
		[RED("npcPuppet")] 
		public CWeakHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
