using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSermoPoseInfo : CVariable
	{
		[Ordinal(0)]  [RED("lod")] public CUInt8 Lod { get; set; }
		[Ordinal(1)]  [RED("trackIndex")] public CUInt16 TrackIndex { get; set; }
		[Ordinal(2)]  [RED("type")] public CUInt8 Type { get; set; }

		public animSermoPoseInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
