using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSplineCompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("posKeysData")] public CArray<CUInt8> PosKeysData { get; set; }
		[Ordinal(2)]  [RED("rotKeysData")] public CArray<CUInt8> RotKeysData { get; set; }

		public animSplineCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
