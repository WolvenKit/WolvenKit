using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		[Ordinal(2)] 
		[RED("npcPuppet")] 
		public CWeakHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		public UploadFromNPCToNPCListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
