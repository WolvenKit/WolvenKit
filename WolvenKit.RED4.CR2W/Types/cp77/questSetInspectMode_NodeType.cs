using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetInspectMode_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] [RED("objectID")] public CString ObjectID { get; set; }
		[Ordinal(1)] [RED("startingOffset")] public CFloat StartingOffset { get; set; }
		[Ordinal(2)] [RED("zoomOffset")] public CFloat ZoomOffset { get; set; }
		[Ordinal(3)] [RED("timeInterval")] public CFloat TimeInterval { get; set; }

		public questSetInspectMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
