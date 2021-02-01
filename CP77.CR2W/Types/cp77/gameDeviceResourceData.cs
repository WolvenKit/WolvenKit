using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDeviceResourceData : ISerializable
	{
		[Ordinal(0)]  [RED("version")] public CUInt32 Version { get; set; }

		public gameDeviceResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
