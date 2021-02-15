using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		[Ordinal(40)] [RED("colorIndex")] public CInt8 ColorIndex { get; set; }

		public gameNetrunnerPrototypeNetworkNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
