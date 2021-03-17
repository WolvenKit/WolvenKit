using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatrolRoleCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CBool _patrolWithWeapon;
		private CBool _forceAlerted;

		[Ordinal(0)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetProperty(ref _patrolWithWeapon);
			set => SetProperty(ref _patrolWithWeapon, value);
		}

		[Ordinal(1)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get => GetProperty(ref _forceAlerted);
			set => SetProperty(ref _forceAlerted, value);
		}

		public PatrolRoleCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
