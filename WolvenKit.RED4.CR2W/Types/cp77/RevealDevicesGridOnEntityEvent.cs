using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDevicesGridOnEntityEvent : redEvent
	{
		private CBool _shouldDraw;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetProperty(ref _shouldDraw);
			set => SetProperty(ref _shouldDraw, value);
		}

		public RevealDevicesGridOnEntityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
