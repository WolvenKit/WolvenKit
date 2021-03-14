using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workReactionSequence : workIContainerEntry
	{
		private CFloat _forcedBlendIn;
		private CArray<TweakDBID> _reactionTypes;
		private CName _mainEmotionalState;
		private CName _emotionalExpression;
		private CFloat _facialKeyWeight;
		private CName _facialIdleMaleAnimation;
		private CName _facialIdleKey_MaleAnimation;
		private CName _facialIdleFemaleAnimation;
		private CName _facialIdleKey_FemaleAnimation;

		[Ordinal(4)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get
			{
				if (_forcedBlendIn == null)
				{
					_forcedBlendIn = (CFloat) CR2WTypeManager.Create("Float", "forcedBlendIn", cr2w, this);
				}
				return _forcedBlendIn;
			}
			set
			{
				if (_forcedBlendIn == value)
				{
					return;
				}
				_forcedBlendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("reactionTypes")] 
		public CArray<TweakDBID> ReactionTypes
		{
			get
			{
				if (_reactionTypes == null)
				{
					_reactionTypes = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "reactionTypes", cr2w, this);
				}
				return _reactionTypes;
			}
			set
			{
				if (_reactionTypes == value)
				{
					return;
				}
				_reactionTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		public workReactionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
