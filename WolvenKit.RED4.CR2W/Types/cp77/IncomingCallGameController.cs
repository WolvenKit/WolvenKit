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
			get => GetProperty(ref _contactNameWidget);
			set => SetProperty(ref _contactNameWidget, value);
		}

		[Ordinal(10)] 
		[RED("phoneBlackboard")] 
		public wCHandle<gameIBlackboard> PhoneBlackboard
		{
			get => GetProperty(ref _phoneBlackboard);
			set => SetProperty(ref _phoneBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get => GetProperty(ref _phoneBBDefinition);
			set => SetProperty(ref _phoneBBDefinition, value);
		}

		[Ordinal(12)] 
		[RED("phoneCallInfoBBID")] 
		public CUInt32 PhoneCallInfoBBID
		{
			get => GetProperty(ref _phoneCallInfoBBID);
			set => SetProperty(ref _phoneCallInfoBBID, value);
		}

		[Ordinal(13)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(14)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public IncomingCallGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
