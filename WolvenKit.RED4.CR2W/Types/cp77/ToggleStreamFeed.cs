using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleStreamFeed : ActionBool
	{
		private CBool _vRoomFake;

		[Ordinal(25)] 
		[RED("vRoomFake")] 
		public CBool VRoomFake
		{
			get => GetProperty(ref _vRoomFake);
			set => SetProperty(ref _vRoomFake, value);
		}

		public ToggleStreamFeed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
