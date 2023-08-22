using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_WorkspotHub : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("additionalLinkIds")] 
		public CArray<workWorkEntryId> AdditionalLinkIds
		{
			get => GetPropertyValue<CArray<workWorkEntryId>>();
			set => SetPropertyValue<CArray<workWorkEntryId>>(value);
		}

		[Ordinal(12)] 
		[RED("additionalLinks")] 
		public CArray<animPoseLink> AdditionalLinks
		{
			get => GetPropertyValue<CArray<animPoseLink>>();
			set => SetPropertyValue<CArray<animPoseLink>>(value);
		}

		[Ordinal(13)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("isCoverHubHack")] 
		public CBool IsCoverHubHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("eventFilterType")] 
		public CEnum<animEventFilterType> EventFilterType
		{
			get => GetPropertyValue<CEnum<animEventFilterType>>();
			set => SetPropertyValue<CEnum<animEventFilterType>>(value);
		}

		[Ordinal(16)] 
		[RED("mainEmotionalState")] 
		public CName MainEmotionalState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("emotionalExpression")] 
		public CName EmotionalExpression
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("facialIdleMaleAnimation")] 
		public CName FacialIdleMaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("facialIdleKey_MaleAnimation")] 
		public CName FacialIdleKey_MaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("facialIdleFemaleAnimation")] 
		public CName FacialIdleFemaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("facialIdleKey_FemaleAnimation")] 
		public CName FacialIdleKey_FemaleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_WorkspotHub()
		{
			Id = uint.MaxValue;
			AdditionalLinkIds = new();
			AdditionalLinks = new();
			FacialKeyWeight = 1.000000F;
			FacialIdleMaleAnimation = "idle__neutral__male";
			FacialIdleFemaleAnimation = "idle__neutral__female";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
