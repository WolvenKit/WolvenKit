using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenShardNotificationAction : GenericNotificationBaseAction
	{
		private CHandle<gameuiGameSystemUI> _eventDispatcher;

		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public CHandle<gameuiGameSystemUI> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		public OpenShardNotificationAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
