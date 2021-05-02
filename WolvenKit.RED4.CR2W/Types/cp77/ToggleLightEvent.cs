using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleLightEvent : redEvent
	{
		private CBool _toggle;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}

		public ToggleLightEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
