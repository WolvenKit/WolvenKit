using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BodyPartHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _bodyPart;
		private CEnum<gamedataAttackSubtype> _attackSubtype;

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CName) CR2WTypeManager.Create("CName", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get
			{
				if (_attackSubtype == null)
				{
					_attackSubtype = (CEnum<gamedataAttackSubtype>) CR2WTypeManager.Create("gamedataAttackSubtype", "attackSubtype", cr2w, this);
				}
				return _attackSubtype;
			}
			set
			{
				if (_attackSubtype == value)
				{
					return;
				}
				_attackSubtype = value;
				PropertySet(this);
			}
		}

		public BodyPartHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
