using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UploadFromNPCToPlayerListener : QuickHackUploadListener
	{
		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public CWeakHandle<ScriptedPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(3)] 
		[RED("npcPuppet")] 
		public CWeakHandle<ScriptedPuppet> NpcPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(4)] 
		[RED("npcSquad")] 
		public CArray<entEntityID> NpcSquad
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(5)] 
		[RED("variantHud")] 
		public HUDProgressBarData VariantHud
		{
			get => GetPropertyValue<HUDProgressBarData>();
			set => SetPropertyValue<HUDProgressBarData>(value);
		}

		[Ordinal(6)] 
		[RED("hudBlackboard")] 
		public CWeakHandle<gameIBlackboard> HudBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("startUploadTimeStamp")] 
		public CFloat StartUploadTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("ssAction")] 
		public CBool SsAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UploadFromNPCToPlayerListener()
		{
			NpcSquad = new();
			VariantHud = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
