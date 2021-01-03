using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entCorpseParameter : entEntityParameter
	{
		[Ordinal(0)]  [RED("bakedBoneNames")] public CArray<CName> BakedBoneNames { get; set; }
		[Ordinal(1)]  [RED("bakedPose")] public CArray<QsTransform> BakedPose { get; set; }
		[Ordinal(2)]  [RED("bones")] public CArray<QsTransform> Bones { get; set; }
		[Ordinal(3)]  [RED("lod")] public CUInt32 Lod { get; set; }
		[Ordinal(4)]  [RED("rigs")] public CArray<raRef<animRig>> Rigs { get; set; }

		public entCorpseParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
