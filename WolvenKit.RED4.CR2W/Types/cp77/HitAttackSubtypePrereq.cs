using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitAttackSubtypePrereq : GenericHitPrereq
	{
		private CEnum<gamedataAttackSubtype> _attackSubtype;

		[Ordinal(5)] 
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

		public HitAttackSubtypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
