using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class appearanceCookedAppearanceData : CResource
	{
		[Ordinal(1)] [RED("dependencies")] public CArray<rRef<CResource>> Dependencies { get; set; }
		[Ordinal(2)] [RED("totalSizeOnDisk")] public CUInt32 TotalSizeOnDisk { get; set; }

		public appearanceCookedAppearanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
