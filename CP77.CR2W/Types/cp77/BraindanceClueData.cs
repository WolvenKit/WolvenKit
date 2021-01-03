using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BraindanceClueData : CVariable
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("id")] public CName Id { get; set; }
		[Ordinal(2)]  [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(3)]  [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(4)]  [RED("state")] public CEnum<ClueState> State { get; set; }

		public BraindanceClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
