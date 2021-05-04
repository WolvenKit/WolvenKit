using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeHitSlowMoEvent : redEvent
	{
		private CBool _isStrongAttack;

		[Ordinal(0)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetProperty(ref _isStrongAttack);
			set => SetProperty(ref _isStrongAttack, value);
		}

		public MeleeHitSlowMoEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
