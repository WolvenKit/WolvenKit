using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleHorsepower : ScannerChunk
	{
		[Ordinal(0)]  [RED("horsepower")] public CInt32 Horsepower { get; set; }

		public ScannerVehicleHorsepower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
