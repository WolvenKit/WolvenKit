using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveHitFlagFromAttackEffector : ModifyAttackEffector
	{
		private CEnum<hitFlag> _hitFlag;
		private CName _reason;

		[Ordinal(0)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get
			{
				if (_hitFlag == null)
				{
					_hitFlag = (CEnum<hitFlag>) CR2WTypeManager.Create("hitFlag", "hitFlag", cr2w, this);
				}
				return _hitFlag;
			}
			set
			{
				if (_hitFlag == value)
				{
					return;
				}
				_hitFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public RemoveHitFlagFromAttackEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
