using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceCounter : CVariable
	{
		[Ordinal(0)]  [RED("devices")] public CArray<CHandle<gameDeviceComponentPS>> Devices { get; set; }
		[Ordinal(1)]  [RED("systemType")] public CEnum<EVirtualSystem> SystemType { get; set; }

		public DeviceCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
