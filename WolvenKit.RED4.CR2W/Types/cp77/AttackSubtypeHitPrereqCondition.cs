using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataAttackSubtype> _attackSubtype;

		[Ordinal(1)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetProperty(ref _attackSubtype);
			set => SetProperty(ref _attackSubtype, value);
		}

		public AttackSubtypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
