using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsTraceResult : CVariable
	{
		[Ordinal(0)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(1)] [RED("normal")] public Vector3 Normal { get; set; }
		[Ordinal(2)] [RED("material")] public CName Material { get; set; }

		public physicsTraceResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
