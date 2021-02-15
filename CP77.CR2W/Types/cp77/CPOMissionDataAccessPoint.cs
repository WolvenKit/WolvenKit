using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataAccessPoint : CPOMissionDevice
	{
		[Ordinal(45)] [RED("hasDataToDownload")] public CBool HasDataToDownload { get; set; }
		[Ordinal(46)] [RED("damagesPresetName")] public CName DamagesPresetName { get; set; }
		[Ordinal(47)] [RED("factsOnDownload")] public CArray<SFactToChange> FactsOnDownload { get; set; }
		[Ordinal(48)] [RED("factsOnUpload")] public CArray<SFactToChange> FactsOnUpload { get; set; }
		[Ordinal(49)] [RED("ownerDecidesOnTransfer")] public CBool OwnerDecidesOnTransfer { get; set; }

		public CPOMissionDataAccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
