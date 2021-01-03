using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CComStaticSkeletonDataEntry : CVariable
	{
		[Ordinal(0)]  [RED("boneIndex")] public CInt32 BoneIndex { get; set; }
		[Ordinal(1)]  [RED("locationLS")] public Vector4 LocationLS { get; set; }
		[Ordinal(2)]  [RED("mass")] public CFloat Mass { get; set; }

		public CComStaticSkeletonDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
