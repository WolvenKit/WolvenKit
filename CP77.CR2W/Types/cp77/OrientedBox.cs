using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OrientedBox : CVariable
	{
		[Ordinal(0)]  [RED("edge_1")] public Vector4 Edge_1 { get; set; }
		[Ordinal(1)]  [RED("edge_2")] public Vector4 Edge_2 { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }

		public OrientedBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
