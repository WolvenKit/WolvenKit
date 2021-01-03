using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsTraceResult : CVariable
	{
		[Ordinal(0)]  [RED("material")] public CName Material { get; set; }
		[Ordinal(1)]  [RED("normal")] public Vector3 Normal { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector3 Position { get; set; }

		public physicsTraceResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
