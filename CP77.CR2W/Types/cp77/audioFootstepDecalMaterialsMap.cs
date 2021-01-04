using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("closestDecalDetectionRadius")] public CFloat ClosestDecalDetectionRadius { get; set; }
		[Ordinal(1)]  [RED("entries")] public CArray<audioFootstepDecalMaterialEntry> Entries { get; set; }

		public audioFootstepDecalMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
