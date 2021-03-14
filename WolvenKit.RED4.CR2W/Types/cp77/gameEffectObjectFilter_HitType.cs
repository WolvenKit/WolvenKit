using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitType : gameEffectObjectSingleFilter
	{
		private CEnum<gameEffectObjectFilter_HitTypeAction> _action;
		private CEnum<gameEffectHitDataType> _hitType;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectObjectFilter_HitTypeAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gameEffectObjectFilter_HitTypeAction>) CR2WTypeManager.Create("gameEffectObjectFilter_HitTypeAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CEnum<gameEffectHitDataType> HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CEnum<gameEffectHitDataType>) CR2WTypeManager.Create("gameEffectHitDataType", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_HitType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
