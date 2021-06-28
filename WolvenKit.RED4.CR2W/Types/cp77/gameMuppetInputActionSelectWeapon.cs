using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionSelectWeapon : gameIMuppetInputAction
	{
		private gameItemID _wantedWeapon;

		[Ordinal(0)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get => GetProperty(ref _wantedWeapon);
			set => SetProperty(ref _wantedWeapon, value);
		}

		public gameMuppetInputActionSelectWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
