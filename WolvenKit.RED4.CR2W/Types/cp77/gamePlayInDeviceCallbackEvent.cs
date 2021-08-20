using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayInDeviceCallbackEvent : redEvent
	{
		private CBool _wasPlayInDeviceSuccessful;

		[Ordinal(0)] 
		[RED("wasPlayInDeviceSuccessful")] 
		public CBool WasPlayInDeviceSuccessful
		{
			get => GetProperty(ref _wasPlayInDeviceSuccessful);
			set => SetProperty(ref _wasPlayInDeviceSuccessful, value);
		}

		public gamePlayInDeviceCallbackEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
