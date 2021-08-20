using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PublicSafeEvents : WeaponEventsTransition
	{
		private CBool _weaponUnequipRequestSent;

		[Ordinal(3)] 
		[RED("weaponUnequipRequestSent")] 
		public CBool WeaponUnequipRequestSent
		{
			get => GetProperty(ref _weaponUnequipRequestSent);
			set => SetProperty(ref _weaponUnequipRequestSent, value);
		}

		public PublicSafeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
