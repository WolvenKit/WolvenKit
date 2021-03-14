using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckAllStatusEffect : AIStatusEffectCondition
	{
		private CName _behaviorArgumentNameTag;
		private CName _behaviorArgumentFloatPriority;
		private CName _behaviorArgumentNameFlag;

		[Ordinal(0)] 
		[RED("behaviorArgumentNameTag")] 
		public CName BehaviorArgumentNameTag
		{
			get
			{
				if (_behaviorArgumentNameTag == null)
				{
					_behaviorArgumentNameTag = (CName) CR2WTypeManager.Create("CName", "behaviorArgumentNameTag", cr2w, this);
				}
				return _behaviorArgumentNameTag;
			}
			set
			{
				if (_behaviorArgumentNameTag == value)
				{
					return;
				}
				_behaviorArgumentNameTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("behaviorArgumentFloatPriority")] 
		public CName BehaviorArgumentFloatPriority
		{
			get
			{
				if (_behaviorArgumentFloatPriority == null)
				{
					_behaviorArgumentFloatPriority = (CName) CR2WTypeManager.Create("CName", "behaviorArgumentFloatPriority", cr2w, this);
				}
				return _behaviorArgumentFloatPriority;
			}
			set
			{
				if (_behaviorArgumentFloatPriority == value)
				{
					return;
				}
				_behaviorArgumentFloatPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("behaviorArgumentNameFlag")] 
		public CName BehaviorArgumentNameFlag
		{
			get
			{
				if (_behaviorArgumentNameFlag == null)
				{
					_behaviorArgumentNameFlag = (CName) CR2WTypeManager.Create("CName", "behaviorArgumentNameFlag", cr2w, this);
				}
				return _behaviorArgumentNameFlag;
			}
			set
			{
				if (_behaviorArgumentNameFlag == value)
				{
					return;
				}
				_behaviorArgumentNameFlag = value;
				PropertySet(this);
			}
		}

		public CheckAllStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
