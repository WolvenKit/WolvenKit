using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		private wCHandle<gameObject> _previousTarget;
		private wCHandle<gameObject> _previousSource;
		private wCHandle<gameweaponObject> _previousWeapon;

		[Ordinal(1)] 
		[RED("previousTarget")] 
		public wCHandle<gameObject> PreviousTarget
		{
			get => GetProperty(ref _previousTarget);
			set => SetProperty(ref _previousTarget, value);
		}

		[Ordinal(2)] 
		[RED("previousSource")] 
		public wCHandle<gameObject> PreviousSource
		{
			get => GetProperty(ref _previousSource);
			set => SetProperty(ref _previousSource, value);
		}

		[Ordinal(3)] 
		[RED("previousWeapon")] 
		public wCHandle<gameweaponObject> PreviousWeapon
		{
			get => GetProperty(ref _previousWeapon);
			set => SetProperty(ref _previousWeapon, value);
		}

		public SameTargetHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
