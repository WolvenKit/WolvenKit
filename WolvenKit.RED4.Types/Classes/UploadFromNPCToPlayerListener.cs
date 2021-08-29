using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UploadFromNPCToPlayerListener : QuickHackUploadListener
	{
		private CWeakHandle<ScriptedPuppet> _playerPuppet;
		private CWeakHandle<ScriptedPuppet> _npcPuppet;
		private CArray<entEntityID> _npcSquad;
		private HUDProgressBarData _variantHud;
		private CWeakHandle<gameIBlackboard> _hudBlackboard;
		private CBool _ssAction;

		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public CWeakHandle<ScriptedPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(3)] 
		[RED("npcPuppet")] 
		public CWeakHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetProperty(ref _npcPuppet);
			set => SetProperty(ref _npcPuppet, value);
		}

		[Ordinal(4)] 
		[RED("npcSquad")] 
		public CArray<entEntityID> NpcSquad
		{
			get => GetProperty(ref _npcSquad);
			set => SetProperty(ref _npcSquad, value);
		}

		[Ordinal(5)] 
		[RED("variantHud")] 
		public HUDProgressBarData VariantHud
		{
			get => GetProperty(ref _variantHud);
			set => SetProperty(ref _variantHud, value);
		}

		[Ordinal(6)] 
		[RED("hudBlackboard")] 
		public CWeakHandle<gameIBlackboard> HudBlackboard
		{
			get => GetProperty(ref _hudBlackboard);
			set => SetProperty(ref _hudBlackboard, value);
		}

		[Ordinal(7)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetProperty(ref _ssAction);
			set => SetProperty(ref _ssAction, value);
		}
	}
}
