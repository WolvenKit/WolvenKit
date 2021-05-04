using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMenuGameController : gameuiWidgetGameController
	{
		private wCHandle<inkMenuEventDispatcher> _baseEventDispatcher;

		[Ordinal(2)] 
		[RED("baseEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher
		{
			get => GetProperty(ref _baseEventDispatcher);
			set => SetProperty(ref _baseEventDispatcher, value);
		}

		public gameuiMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
