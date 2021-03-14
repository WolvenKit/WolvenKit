using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttackTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataAttackType> _attackType;

		[Ordinal(1)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (CEnum<gamedataAttackType>) CR2WTypeManager.Create("gamedataAttackType", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		public AttackTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
