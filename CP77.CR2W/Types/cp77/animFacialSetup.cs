using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup : CResource
	{
		[Ordinal(0)]  [RED("bakedData")] public DataBuffer BakedData { get; set; }
		[Ordinal(1)]  [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
		[Ordinal(2)]  [RED("eyesCorrectiveNames")] public CArray<CName> EyesCorrectiveNames { get; set; }
		[Ordinal(3)]  [RED("faceCorrectiveNames")] public CArray<CName> FaceCorrectiveNames { get; set; }
		[Ordinal(4)]  [RED("info")] public animFacialSetup_BufferInfo Info { get; set; }
		[Ordinal(5)]  [RED("inputRig")] public rRef<animRig> InputRig { get; set; }
		[Ordinal(6)]  [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
		[Ordinal(7)]  [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
		[Ordinal(8)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(9)]  [RED("tongueCorrectiveNames")] public CArray<CName> TongueCorrectiveNames { get; set; }
		[Ordinal(10)]  [RED("useFemaleAnimSet")] public CBool UseFemaleAnimSet { get; set; }
		[Ordinal(11)]  [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
		[Ordinal(12)]  [RED("version")] public CUInt32 Version { get; set; }

		public animFacialSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
