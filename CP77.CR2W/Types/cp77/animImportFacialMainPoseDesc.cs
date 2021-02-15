using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animImportFacialMainPoseDesc : CVariable
	{
		[Ordinal(0)] [RED("influencedBy")] public CArray<CName> InfluencedBy { get; set; }
		[Ordinal(1)] [RED("influenceMainWeightIndices")] public CArray<CUInt16> InfluenceMainWeightIndices { get; set; }
		[Ordinal(2)] [RED("poses")] public CArray<animImportFacialPoseDesc> Poses { get; set; }
		[Ordinal(3)] [RED("poseIndices")] public CArray<CUInt16> PoseIndices { get; set; }
		[Ordinal(4)] [RED("weights")] public CArray<CFloat> Weights { get; set; }
		[Ordinal(5)] [RED("inBetweenScopeMultipliers")] public CArray<CFloat> InBetweenScopeMultipliers { get; set; }
		[Ordinal(6)] [RED("name")] public CName Name { get; set; }
		[Ordinal(7)] [RED("index")] public CUInt16 Index { get; set; }
		[Ordinal(8)] [RED("influenceType")] public CUInt8 InfluenceType { get; set; }
		[Ordinal(9)] [RED("side")] public CUInt8 Side { get; set; }
		[Ordinal(10)] [RED("facePart")] public CUInt8 FacePart { get; set; }

		public animImportFacialMainPoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
