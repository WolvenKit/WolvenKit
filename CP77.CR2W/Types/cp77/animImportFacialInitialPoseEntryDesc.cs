using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialPoseEntryDesc : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CInt16 Id { get; set; }
		[Ordinal(1)]  [RED("initAnimationPoseMax")] public CFloat InitAnimationPoseMax { get; set; }
		[Ordinal(2)]  [RED("initAnimationPoseMid")] public CFloat InitAnimationPoseMid { get; set; }
		[Ordinal(3)]  [RED("initAnimationPoseMin")] public CFloat InitAnimationPoseMin { get; set; }
		[Ordinal(4)]  [RED("isCachable")] public CBool IsCachable { get; set; }
		[Ordinal(5)]  [RED("poseName")] public CName PoseName { get; set; }
		[Ordinal(6)]  [RED("side")] public CUInt8 Side { get; set; }
		[Ordinal(7)]  [RED("type")] public CUInt8 Type { get; set; }
		[Ordinal(8)]  [RED("weight")] public CFloat Weight { get; set; }

		public animImportFacialInitialPoseEntryDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
