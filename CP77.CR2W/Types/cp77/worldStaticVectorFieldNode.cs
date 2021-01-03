using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStaticVectorFieldNode : worldNode
	{
		[Ordinal(0)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(1)]  [RED("direction")] public Vector3 Direction { get; set; }

		public worldStaticVectorFieldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
