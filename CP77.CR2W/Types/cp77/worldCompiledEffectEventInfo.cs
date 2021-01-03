using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectEventInfo : CVariable
	{
		[Ordinal(0)]  [RED("componentIndexMask")] public CUInt64 ComponentIndexMask { get; set; }
		[Ordinal(1)]  [RED("eventRUID")] public CRUID EventRUID { get; set; }
		[Ordinal(2)]  [RED("flags")] public CUInt8 Flags { get; set; }
		[Ordinal(3)]  [RED("placementIndexMask")] public CUInt64 PlacementIndexMask { get; set; }

		public worldCompiledEffectEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
