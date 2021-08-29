using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitAttackSubtypePrereq : GenericHitPrereq
	{
		private CEnum<gamedataAttackSubtype> _attackSubtype;

		[Ordinal(5)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetProperty(ref _attackSubtype);
			set => SetProperty(ref _attackSubtype, value);
		}
	}
}
