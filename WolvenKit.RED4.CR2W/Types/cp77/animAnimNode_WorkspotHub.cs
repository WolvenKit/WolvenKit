using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotHub : animAnimNode_Base
	{
		private CArray<workWorkEntryId> _additionalLinkIds;
		private CArray<animPoseLink> _additionalLinks;
		private CName _animLoopEventName;
		private CBool _isCoverHubHack;
		private CEnum<animEventFilterType> _eventFilterType;
		private CName _mainEmotionalState;
		private CName _emotionalExpression;
		private CFloat _facialKeyWeight;
		private CName _facialIdleMaleAnimation;
		private CName _facialIdleKey_MaleAnimation;
		private CName _facialIdleFemaleAnimation;
		private CName _facialIdleKey_FemaleAnimation;

		[Ordinal(11)] 
		[RED("additionalLinkIds")] 
		public CArray<workWorkEntryId> AdditionalLinkIds
		{
			get => GetProperty(ref _additionalLinkIds);
			set => SetProperty(ref _additionalLinkIds, value);
		}

		[Ordinal(12)] 
		[RED("additionalLinks")] 
		public CArray<animPoseLink> AdditionalLinks
		{
			get => GetProperty(ref _additionalLinks);
			set => SetProperty(ref _additionalLinks, value);
		}

		[Ordinal(13)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get => GetProperty(ref _animLoopEventName);
			set => SetProperty(ref _animLoopEventName, value);
		}

		[Ordinal(14)] 
		[RED("isCoverHubHack")] 
		public CBool IsCoverHubHack
		{
			get => GetProperty(ref _isCoverHubHack);
			set => SetProperty(ref _isCoverHubHack, value);
		}

		[Ordinal(15)] 
		[RED("eventFilterType")] 
		public CEnum<animEventFilterType> EventFilterType
		{
			get => GetProperty(ref _eventFilterType);
			set => SetProperty(ref _eventFilterType, value);
		}

		[Ordinal(16)] 
		[RED("mainEmotionalState")] 
		public CName MainEmotionalState
		{
			get => GetProperty(ref _mainEmotionalState);
			set => SetProperty(ref _mainEmotionalState, value);
		}

		[Ordinal(17)] 
		[RED("emotionalExpression")] 
		public CName EmotionalExpression
		{
			get => GetProperty(ref _emotionalExpression);
			set => SetProperty(ref _emotionalExpression, value);
		}

		[Ordinal(18)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetProperty(ref _facialKeyWeight);
			set => SetProperty(ref _facialKeyWeight, value);
		}

		[Ordinal(19)] 
		[RED("facialIdleMaleAnimation")] 
		public CName FacialIdleMaleAnimation
		{
			get => GetProperty(ref _facialIdleMaleAnimation);
			set => SetProperty(ref _facialIdleMaleAnimation, value);
		}

		[Ordinal(20)] 
		[RED("facialIdleKey_MaleAnimation")] 
		public CName FacialIdleKey_MaleAnimation
		{
			get => GetProperty(ref _facialIdleKey_MaleAnimation);
			set => SetProperty(ref _facialIdleKey_MaleAnimation, value);
		}

		[Ordinal(21)] 
		[RED("facialIdleFemaleAnimation")] 
		public CName FacialIdleFemaleAnimation
		{
			get => GetProperty(ref _facialIdleFemaleAnimation);
			set => SetProperty(ref _facialIdleFemaleAnimation, value);
		}

		[Ordinal(22)] 
		[RED("facialIdleKey_FemaleAnimation")] 
		public CName FacialIdleKey_FemaleAnimation
		{
			get => GetProperty(ref _facialIdleKey_FemaleAnimation);
			set => SetProperty(ref _facialIdleKey_FemaleAnimation, value);
		}

		public animAnimNode_WorkspotHub(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
