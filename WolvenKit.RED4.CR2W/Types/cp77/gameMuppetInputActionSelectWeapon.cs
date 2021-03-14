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
			get
			{
				if (_wantedWeapon == null)
				{
					_wantedWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "wantedWeapon", cr2w, this);
				}
				return _wantedWeapon;
			}
			set
			{
				if (_wantedWeapon == value)
				{
					return;
				}
				_wantedWeapon = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionSelectWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
