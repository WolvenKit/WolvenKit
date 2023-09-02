using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get => GetPropertyValue<CHandle<BaseScriptableAction>>();
			set => SetPropertyValue<CHandle<BaseScriptableAction>>(value);
		}

		[Ordinal(1)] 
		[RED("actionOwner")] 
		public entEntityID ActionOwner
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("actionOwnerName")] 
		public CName ActionOwnerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("iconCategory")] 
		public CName IconCategory
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("titleAlternative")] 
		public CString TitleAlternative
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("actionState")] 
		public CEnum<EActionInactivityReson> ActionState
		{
			get => GetPropertyValue<CEnum<EActionInactivityReson>>();
			set => SetPropertyValue<CEnum<EActionInactivityReson>>(value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataObjectActionType> Type
		{
			get => GetPropertyValue<CEnum<gamedataObjectActionType>>();
			set => SetPropertyValue<CEnum<gamedataObjectActionType>>(value);
		}

		[Ordinal(12)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("costRaw")] 
		public CInt32 CostRaw
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("ICELevelVisible")] 
		public CBool ICELevelVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("ICELevel")] 
		public CFloat ICELevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("vulnerabilities")] 
		public CArray<TweakDBID> Vulnerabilities
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(19)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("cooldownTweak")] 
		public TweakDBID CooldownTweak
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(23)] 
		[RED("actionMatchesTarget")] 
		public CBool ActionMatchesTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("maxListSize")] 
		public CInt32 MaxListSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("category")] 
		public CWeakHandle<gamedataHackCategory_Record> Category
		{
			get => GetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>(value);
		}

		[Ordinal(26)] 
		[RED("actionCompletionEffects")] 
		public CArray<CWeakHandle<gamedataObjectActionEffect_Record>> ActionCompletionEffects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataObjectActionEffect_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataObjectActionEffect_Record>>>(value);
		}

		[Ordinal(27)] 
		[RED("networkBreached")] 
		public CBool NetworkBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickhackData()
		{
			ActionOwner = new entEntityID();
			Vulnerabilities = new();
			ActionCompletionEffects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
