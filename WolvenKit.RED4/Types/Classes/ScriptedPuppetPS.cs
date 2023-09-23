using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptedPuppetPS : gamePuppetPS
	{
		[Ordinal(6)] 
		[RED("deviceLink")] 
		public CWeakHandle<PuppetDeviceLinkPS> DeviceLink
		{
			get => GetPropertyValue<CWeakHandle<PuppetDeviceLinkPS>>();
			set => SetPropertyValue<CWeakHandle<PuppetDeviceLinkPS>>(value);
		}

		[Ordinal(7)] 
		[RED("cooldownStorage")] 
		public CHandle<CooldownStorage> CooldownStorage
		{
			get => GetPropertyValue<CHandle<CooldownStorage>>();
			set => SetPropertyValue<CHandle<CooldownStorage>>(value);
		}

		[Ordinal(8)] 
		[RED("isInitialized")] 
		public CEnum<EBOOL> IsInitialized
		{
			get => GetPropertyValue<CEnum<EBOOL>>();
			set => SetPropertyValue<CEnum<EBOOL>>(value);
		}

		[Ordinal(9)] 
		[RED("wasAttached")] 
		public CBool WasAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("numberActions")] 
		public CInt32 NumberActions
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("hasDirectInteractionChoicesActive")] 
		public CBool HasDirectInteractionChoicesActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("wasIncapacitated")] 
		public CBool WasIncapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isIncapacitated")] 
		public CBool IsIncapacitated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isAndroidTurnedOff")] 
		public CBool IsAndroidTurnedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isPreventionNotified")] 
		public CBool IsPreventionNotified
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetPropertyValue<SecuritySystemData>();
			set => SetPropertyValue<SecuritySystemData>(value);
		}

		[Ordinal(21)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get => GetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedeviceRequestType>>>(value);
		}

		[Ordinal(22)] 
		[RED("lastInteractionLayerTag")] 
		public CName LastInteractionLayerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("quickHacksExposed")] 
		public CBool QuickHacksExposed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("currentCooldownID")] 
		public CUInt32 CurrentCooldownID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("reactionPresetID")] 
		public TweakDBID ReactionPresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(26)] 
		[RED("isDefeatMechanicActive")] 
		public CBool IsDefeatMechanicActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("leftHandLoadout")] 
		public gameItemID LeftHandLoadout
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(28)] 
		[RED("rightHandLoadout")] 
		public gameItemID RightHandLoadout
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(29)] 
		[RED("customWeaponLoadout")] 
		public CArray<CachedItemLoadout> CustomWeaponLoadout
		{
			get => GetPropertyValue<CArray<CachedItemLoadout>>();
			set => SetPropertyValue<CArray<CachedItemLoadout>>(value);
		}

		[Ordinal(30)] 
		[RED("genericMeleeLoadout")] 
		public CachedItemLoadout GenericMeleeLoadout
		{
			get => GetPropertyValue<CachedItemLoadout>();
			set => SetPropertyValue<CachedItemLoadout>(value);
		}

		[Ordinal(31)] 
		[RED("genericRangedLoadout")] 
		public CachedItemLoadout GenericRangedLoadout
		{
			get => GetPropertyValue<CachedItemLoadout>();
			set => SetPropertyValue<CachedItemLoadout>(value);
		}

		[Ordinal(32)] 
		[RED("questForceScannerPreset")] 
		public TweakDBID QuestForceScannerPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(33)] 
		[RED("bountyID")] 
		public TweakDBID BountyID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(34)] 
		[RED("transgressions")] 
		public CArray<TweakDBID> Transgressions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public ScriptedPuppetPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
