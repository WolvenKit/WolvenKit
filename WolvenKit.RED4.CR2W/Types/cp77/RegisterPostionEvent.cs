using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPostionEvent : BlackBoardRequestEvent
	{
		private CBool _start;

		[Ordinal(3)] 
		[RED("start")] 
		public CBool Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		public RegisterPostionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
