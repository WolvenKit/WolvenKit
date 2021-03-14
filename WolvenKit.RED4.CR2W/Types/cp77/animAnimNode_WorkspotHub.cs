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
			get
			{
				if (_additionalLinkIds == null)
				{
					_additionalLinkIds = (CArray<workWorkEntryId>) CR2WTypeManager.Create("array:workWorkEntryId", "additionalLinkIds", cr2w, this);
				}
				return _additionalLinkIds;
			}
			set
			{
				if (_additionalLinkIds == value)
				{
					return;
				}
				_additionalLinkIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("additionalLinks")] 
		public CArray<animPoseLink> AdditionalLinks
		{
			get
			{
				if (_additionalLinks == null)
				{
					_additionalLinks = (CArray<animPoseLink>) CR2WTypeManager.Create("array:animPoseLink", "additionalLinks", cr2w, this);
				}
				return _additionalLinks;
			}
			set
			{
				if (_additionalLinks == value)
				{
					return;
				}
				_additionalLinks = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get
			{
				if (_animLoopEventName == null)
				{
					_animLoopEventName = (CName) CR2WTypeManager.Create("CName", "animLoopEventName", cr2w, this);
				}
				return _animLoopEventName;
			}
			set
			{
				if (_animLoopEventName == value)
				{
					return;
				}
				_animLoopEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isCoverHubHack")] 
		public CBool IsCoverHubHack
		{
			get
			{
				if (_isCoverHubHack == null)
				{
					_isCoverHubHack = (CBool) CR2WTypeManager.Create("Bool", "isCoverHubHack", cr2w, this);
				}
				return _isCoverHubHack;
			}
			set
			{
				if (_isCoverHubHack == value)
				{
					return;
				}
				_isCoverHubHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("eventFilterType")] 
		public CEnum<animEventFilterType> EventFilterType
		{
			get
			{
				if (_eventFilterType == null)
				{
					_eventFilterType = (CEnum<animEventFilterType>) CR2WTypeManager.Create("animEventFilterType", "eventFilterType", cr2w, this);
				}
				return _eventFilterType;
			}
			set
			{
				if (_eventFilterType == value)
				{
					return;
				}
				_eventFilterType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("mainEmotionalState")] 
		public CName MainEmotionalState
		{
			get
			{
				if (_mainEmotionalState == null)
				{
					_mainEmotionalState = (CName) CR2WTypeManager.Create("CName", "mainEmotionalState", cr2w, this);
				}
				return _mainEmotionalState;
			}
			set
			{
				if (_mainEmotionalState == value)
				{
					return;
				}
				_mainEmotionalState = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("emotionalExpression")] 
		public CName EmotionalExpression
		{
			get
			{
				if (_emotionalExpression == null)
				{
					_emotionalExpression = (CName) CR2WTypeManager.Create("CName", "emotionalExpression", cr2w, this);
				}
				return _emotionalExpression;
			}
			set
			{
				if (_emotionalExpression == value)
				{
					return;
				}
				_emotionalExpression = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get
			{
				if (_facialKeyWeight == null)
				{
					_facialKeyWeight = (CFloat) CR2WTypeManager.Create("Float", "facialKeyWeight", cr2w, this);
				}
				return _facialKeyWeight;
			}
			set
			{
				if (_facialKeyWeight == value)
				{
					return;
				}
				_facialKeyWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("facialIdleMaleAnimation")] 
		public CName FacialIdleMaleAnimation
		{
			get
			{
				if (_facialIdleMaleAnimation == null)
				{
					_facialIdleMaleAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleMaleAnimation", cr2w, this);
				}
				return _facialIdleMaleAnimation;
			}
			set
			{
				if (_facialIdleMaleAnimation == value)
				{
					return;
				}
				_facialIdleMaleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("facialIdleKey_MaleAnimation")] 
		public CName FacialIdleKey_MaleAnimation
		{
			get
			{
				if (_facialIdleKey_MaleAnimation == null)
				{
					_facialIdleKey_MaleAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleKey_MaleAnimation", cr2w, this);
				}
				return _facialIdleKey_MaleAnimation;
			}
			set
			{
				if (_facialIdleKey_MaleAnimation == value)
				{
					return;
				}
				_facialIdleKey_MaleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("facialIdleFemaleAnimation")] 
		public CName FacialIdleFemaleAnimation
		{
			get
			{
				if (_facialIdleFemaleAnimation == null)
				{
					_facialIdleFemaleAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleFemaleAnimation", cr2w, this);
				}
				return _facialIdleFemaleAnimation;
			}
			set
			{
				if (_facialIdleFemaleAnimation == value)
				{
					return;
				}
				_facialIdleFemaleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("facialIdleKey_FemaleAnimation")] 
		public CName FacialIdleKey_FemaleAnimation
		{
			get
			{
				if (_facialIdleKey_FemaleAnimation == null)
				{
					_facialIdleKey_FemaleAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleKey_FemaleAnimation", cr2w, this);
				}
				return _facialIdleKey_FemaleAnimation;
			}
			set
			{
				if (_facialIdleKey_FemaleAnimation == value)
				{
					return;
				}
				_facialIdleKey_FemaleAnimation = value;
				PropertySet(this);
			}
		}

		public animAnimNode_WorkspotHub(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
