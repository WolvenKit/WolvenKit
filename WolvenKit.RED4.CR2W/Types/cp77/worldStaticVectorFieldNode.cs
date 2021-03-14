using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticVectorFieldNode : worldNode
	{
		[Ordinal(4)] [RED("direction")] public Vector3 Direction { get; set; }
		[Ordinal(5)] [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }

		public worldStaticVectorFieldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
