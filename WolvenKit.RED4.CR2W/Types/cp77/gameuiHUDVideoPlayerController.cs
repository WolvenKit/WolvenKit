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
			get => GetProperty(ref _playOnHud);
			set => SetProperty(ref _playOnHud, value);
		}

		public gameuiHUDVideoPlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
