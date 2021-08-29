using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		private CWeakHandle<ScriptedPuppet> _npcPuppet;

		[Ordinal(2)] 
		[RED("npcPuppet")] 
		public CWeakHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetProperty(ref _npcPuppet);
			set => SetProperty(ref _npcPuppet, value);
		}
	}
}
