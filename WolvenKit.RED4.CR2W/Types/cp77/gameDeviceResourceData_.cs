using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceResourceData_ : ISerializable
	{
		[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }

		public gameDeviceResourceData_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
