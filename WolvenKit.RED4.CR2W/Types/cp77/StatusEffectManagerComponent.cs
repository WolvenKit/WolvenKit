using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectManagerComponent : AIMandatoryComponents
	{
		private CBool _weaponDropedInWounded;

		[Ordinal(5)] 
		[RED("weaponDropedInWounded")] 
		public CBool WeaponDropedInWounded
		{
			get => GetProperty(ref _weaponDropedInWounded);
			set => SetProperty(ref _weaponDropedInWounded, value);
		}

		public StatusEffectManagerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
