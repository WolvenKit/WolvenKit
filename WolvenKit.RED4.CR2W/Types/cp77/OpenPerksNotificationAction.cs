using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenPerksNotificationAction : GenericNotificationBaseAction
	{
		private wCHandle<worlduiIWidgetGameController> _eventDispatcher;

		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public wCHandle<worlduiIWidgetGameController> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		public OpenPerksNotificationAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
