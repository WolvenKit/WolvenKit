using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveCustomMoveEvent : gameActionEvent
	{
		private CInt32 _test;

		[Ordinal(4)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetProperty(ref _test);
			set => SetProperty(ref _test, value);
		}

		public moveCustomMoveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
