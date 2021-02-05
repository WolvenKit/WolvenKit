using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup : CResource
	{
		[Ordinal(0)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(1)]  [RED("inputRig")] public rRef<animRig> InputRig { get; set; }
		[Ordinal(2)]  [RED("info")] public animFacialSetup_BufferInfo Info { get; set; }
		[Ordinal(3)]  [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
		[Ordinal(4)]  [RED("bakedData")] public DataBuffer BakedData { get; set; }
		[Ordinal(5)]  [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
		[Ordinal(6)]  [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
		[Ordinal(7)]  [RED("faceCorrectiveNames")] public CArray<CName> FaceCorrectiveNames { get; set; }
		[Ordinal(8)]  [RED("tongueCorrectiveNames")] public CArray<CName> TongueCorrectiveNames { get; set; }
		[Ordinal(9)]  [RED("eyesCorrectiveNames")] public CArray<CName> EyesCorrectiveNames { get; set; }
		[Ordinal(10)]  [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
		[Ordinal(11)]  [RED("useFemaleAnimSet")] public CBool UseFemaleAnimSet { get; set; }
		[Ordinal(12)]  [RED("version")] public CUInt32 Version { get; set; }

		public animFacialSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
