using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _previousChannel;
		private gamebbScriptID_Int32 _currentChannel;

		[Ordinal(7)] 
		[RED("PreviousChannel")] 
		public gamebbScriptID_Int32 PreviousChannel
		{
			get => GetProperty(ref _previousChannel);
			set => SetProperty(ref _previousChannel, value);
		}

		[Ordinal(8)] 
		[RED("CurrentChannel")] 
		public gamebbScriptID_Int32 CurrentChannel
		{
			get => GetProperty(ref _currentChannel);
			set => SetProperty(ref _currentChannel, value);
		}

		public TVDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
