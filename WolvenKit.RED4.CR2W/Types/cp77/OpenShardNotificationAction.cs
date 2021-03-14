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
			get
			{
				if (_eventDispatcher == null)
				{
					_eventDispatcher = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "eventDispatcher", cr2w, this);
				}
				return _eventDispatcher;
			}
			set
			{
				if (_eventDispatcher == value)
				{
					return;
				}
				_eventDispatcher = value;
				PropertySet(this);
			}
		}

		public OpenShardNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
