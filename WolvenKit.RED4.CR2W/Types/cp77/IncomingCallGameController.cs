using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncomingCallGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _contactNameWidget;
		private wCHandle<gameIBlackboard> _phoneBlackboard;
		private CHandle<UI_ComDeviceDef> _phoneBBDefinition;
		private CUInt32 _phoneCallInfoBBID;
		private wCHandle<gameObject> _owner;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(9)] 
		[RED("contactNameWidget")] 
		public inkTextWidgetReference ContactNameWidget
		{
			get
			{
				if (_contactNameWidget == null)
				{
					_contactNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "contactNameWidget", cr2w, this);
				}
				return _contactNameWidget;
			}
			set
			{
				if (_contactNameWidget == value)
				{
					return;
				}
				_contactNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("phoneBlackboard")] 
		public wCHandle<gameIBlackboard> PhoneBlackboard
		{
			get
			{
				if (_phoneBlackboard == null)
				{
					_phoneBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "phoneBlackboard", cr2w, this);
				}
				return _phoneBlackboard;
			}
			set
			{
				if (_phoneBlackboard == value)
				{
					return;
				}
				_phoneBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get
			{
				if (_phoneBBDefinition == null)
				{
					_phoneBBDefinition = (CHandle<UI_ComDeviceDef>) CR2WTypeManager.Create("handle:UI_ComDeviceDef", "phoneBBDefinition", cr2w, this);
				}
				return _phoneBBDefinition;
			}
			set
			{
				if (_phoneBBDefinition == value)
				{
					return;
				}
				_phoneBBDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("phoneCallInfoBBID")] 
		public CUInt32 PhoneCallInfoBBID
		{
			get
			{
				if (_phoneCallInfoBBID == null)
				{
					_phoneCallInfoBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "phoneCallInfoBBID", cr2w, this);
				}
				return _phoneCallInfoBBID;
			}
			set
			{
				if (_phoneCallInfoBBID == value)
				{
					return;
				}
				_phoneCallInfoBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public IncomingCallGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
