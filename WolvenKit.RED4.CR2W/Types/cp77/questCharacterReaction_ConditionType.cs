using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterReaction_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private CBool _isAnyReaction;
		private TweakDBID _reactionBehaviorID;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAnyReaction")] 
		public CBool IsAnyReaction
		{
			get
			{
				if (_isAnyReaction == null)
				{
					_isAnyReaction = (CBool) CR2WTypeManager.Create("Bool", "isAnyReaction", cr2w, this);
				}
				return _isAnyReaction;
			}
			set
			{
				if (_isAnyReaction == value)
				{
					return;
				}
				_isAnyReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reactionBehaviorID")] 
		public TweakDBID ReactionBehaviorID
		{
			get
			{
				if (_reactionBehaviorID == null)
				{
					_reactionBehaviorID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "reactionBehaviorID", cr2w, this);
				}
				return _reactionBehaviorID;
			}
			set
			{
				if (_reactionBehaviorID == value)
				{
					return;
				}
				_reactionBehaviorID = value;
				PropertySet(this);
			}
		}

		public questCharacterReaction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
