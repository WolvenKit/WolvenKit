using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLineVertex : CVariable
	{
		[Ordinal(0)]  [RED("int")] public Vector2 Int { get; set; }
		[Ordinal(1)]  [RED("neType")] public CEnum<inkLineType> NeType { get; set; }

		public inkLineVertex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
