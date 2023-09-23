using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("actionOwner")] 
		public entEntityID ActionOwner
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get => GetPropertyValue<CHandle<BaseScriptableAction>>();
			set => SetPropertyValue<CHandle<BaseScriptableAction>>(value);
		}

		[Ordinal(2)] 
		[RED("actionOwnerName")] 
		public CName ActionOwnerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("iconCategory")] 
		public CName IconCategory
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("titleAlternative")] 
		public CString TitleAlternative
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("actionState")] 
		public CEnum<EActionInactivityReson> ActionState
		{
			get => GetPropertyValue<CEnum<EActionInactivityReson>>();
			set => SetPropertyValue<CEnum<EActionInactivityReson>>(value);
		}

		[Ordinal(12)] 
		[RED("type")] 
		public CEnum<gamedataObjectActionType> Type
		{
			get => GetPropertyValue<CEnum<gamedataObjectActionType>>();
			set => SetPropertyValue<CEnum<gamedataObjectActionType>>(value);
		}

		[Ordinal(13)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("awarenessCost")] 
		public CFloat AwarenessCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("showRevealInfo")] 
		public CBool ShowRevealInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("willReveal")] 
		public CBool WillReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("costRaw")] 
		public CInt32 CostRaw
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("ICELevelVisible")] 
		public CBool ICELevelVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("ICELevel")] 
		public CFloat ICELevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("vulnerabilities")] 
		public CArray<TweakDBID> Vulnerabilities
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(23)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("cooldownTweak")] 
		public TweakDBID CooldownTweak
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(27)] 
		[RED("actionMatchesTarget")] 
		public CBool ActionMatchesTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("maxListSize")] 
		public CInt32 MaxListSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("category")] 
		public CWeakHandle<gamedataHackCategory_Record> Category
		{
			get => GetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>(value);
		}

		[Ordinal(30)] 
		[RED("actionCompletionEffects")] 
		public CArray<CWeakHandle<gamedataObjectActionEffect_Record>> ActionCompletionEffects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataObjectActionEffect_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataObjectActionEffect_Record>>>(value);
		}

		[Ordinal(31)] 
		[RED("noQuickhackData")] 
		public CBool NoQuickhackData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("networkBreached")] 
		public CBool NetworkBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickhackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
