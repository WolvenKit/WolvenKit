using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OrientedBox : CVariable
	{
		[Ordinal(0)]  [RED("edge 1")] public Vector4 Edg1 { get; set; }
		[Ordinal(1)]  [RED("edge 2")] public Vector4 Edg2 { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }

		public OrientedBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
