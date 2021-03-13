using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleHorsepower : ScannerChunk
	{
		[Ordinal(0)] [RED("horsepower")] public CInt32 Horsepower { get; set; }

		public ScannerVehicleHorsepower(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
