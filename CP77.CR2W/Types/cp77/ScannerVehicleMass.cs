using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleMass : ScannerChunk
	{
		[Ordinal(0)]  [RED("mass")] public CInt32 Mass { get; set; }

		public ScannerVehicleMass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
