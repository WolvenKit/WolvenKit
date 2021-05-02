using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhysicalHackingEvent : redEvent
	{
		private CString _deviceName;

		[Ordinal(0)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}

		public PhysicalHackingEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
