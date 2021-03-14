using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		private CBool _playOnHud;

		[Ordinal(9)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get
			{
				if (_playOnHud == null)
				{
					_playOnHud = (CBool) CR2WTypeManager.Create("Bool", "playOnHud", cr2w, this);
				}
				return _playOnHud;
			}
			set
			{
				if (_playOnHud == value)
				{
					return;
				}
				_playOnHud = value;
				PropertySet(this);
			}
		}

		public gameuiHUDVideoPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
