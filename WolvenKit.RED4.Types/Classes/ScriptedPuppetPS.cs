using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptedPuppetPS : gamePuppetPS
	{
		[Ordinal(4)] 
		[RED("deviceLink")] 
		public CWeakHandle<PuppetDeviceLinkPS> DeviceLink
		{
			get => GetPropertyValue<CWeakHandle<PuppetDeviceLinkPS>>();
			set => SetPropertyValue<CWeakHandle<PuppetDeviceLinkPS>>(value);
		}

		[Ordinal(5)] 
		[RED("cooldownStorage")] 
		public CHandle<CooldownStorage> CooldownStorage
		{
			get => GetPropertyValue<CHandle<CooldownStorage>>();
			set => SetPropertyValue<CHandle<CooldownStorage>>(value);
		}

		[Ordinal(6)] 
		[RED("isInitialized")] 
		public CEnum<EBOOL> IsInitialized
		{
			get => GetPropertyValue<CEnum<EBOOL>>();
			set => SetPropertyValue<CEnum<EBOOL>>(value);
		}

		[Ordinal(7)] 
		[RED("wasAttached")] 
		public CBool WasAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("numberActions")] 
		public CInt32 NumberActions
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("hasDirectInteractionChoicesActive")] 
		public CBool HasDirectInteractionChoicesActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("wasIncapacitated")] 
		public CBool WasIncapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isIncapacitated")] 
		public CBool IsIncapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isAndroidTurnedOff")] 
		public CBool IsAndroidTurnedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetPropertyValue<SecuritySystemData>();
			set => SetPropertyValue<SecuritySystemData>(value);
		}

		[Ordinal(18)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get => GetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>(value);
		}

		[Ordinal(19)] 
		[RED("lastInteractionLayerTag")] 
		public CName LastInteractionLayerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("quickHacksExposed")] 
		public CBool QuickHacksExposed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("currentCooldownID")] 
		public CUInt32 CurrentCooldownID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(22)] 
		[RED("reactionPresetID")] 
		public TweakDBID ReactionPresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(23)] 
		[RED("isDefeatMechanicActive")] 
		public CBool IsDefeatMechanicActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("leftHandLoadout")] 
		public gameItemID LeftHandLoadout
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(25)] 
		[RED("rightHandLoadout")] 
		public gameItemID RightHandLoadout
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public ScriptedPuppetPS()
		{
			SecuritySystemData = new();
			ActiveContexts = new();
			IsDefeatMechanicActive = true;
			LeftHandLoadout = new();
			RightHandLoadout = new();
		}
	}
}
