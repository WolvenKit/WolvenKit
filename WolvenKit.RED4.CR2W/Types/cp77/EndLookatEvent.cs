using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EndLookatEvent : redEvent
	{
		private CBool _repeat;

		[Ordinal(0)] 
		[RED("repeat")] 
		public CBool Repeat
		{
			get => GetProperty(ref _repeat);
			set => SetProperty(ref _repeat, value);
		}

		public EndLookatEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
