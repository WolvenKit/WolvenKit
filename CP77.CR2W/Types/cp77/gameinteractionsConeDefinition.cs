using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsConeDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)]  [RED("pos1")] public Vector4 Pos1 { get; set; }
		[Ordinal(1)]  [RED("pos2")] public Vector4 Pos2 { get; set; }
		[Ordinal(2)]  [RED("radius1")] public CFloat Radius1 { get; set; }
		[Ordinal(3)]  [RED("radius2")] public CFloat Radius2 { get; set; }

		public gameinteractionsConeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
