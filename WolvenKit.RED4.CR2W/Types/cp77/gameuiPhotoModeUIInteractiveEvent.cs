using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeUIInteractiveEvent : redEvent
	{
		private CBool _interactive;

		[Ordinal(0)] 
		[RED("interactive")] 
		public CBool Interactive
		{
			get => GetProperty(ref _interactive);
			set => SetProperty(ref _interactive, value);
		}

		public gameuiPhotoModeUIInteractiveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
