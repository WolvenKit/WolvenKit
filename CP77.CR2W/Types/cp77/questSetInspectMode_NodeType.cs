using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetInspectMode_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)]  [RED("objectID")] public CString ObjectID { get; set; }
		[Ordinal(1)]  [RED("startingOffset")] public CFloat StartingOffset { get; set; }
		[Ordinal(2)]  [RED("timeInterval")] public CFloat TimeInterval { get; set; }
		[Ordinal(3)]  [RED("zoomOffset")] public CFloat ZoomOffset { get; set; }

		public questSetInspectMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
