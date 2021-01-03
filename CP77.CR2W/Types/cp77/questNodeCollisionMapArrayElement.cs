using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questNodeCollisionMapArrayElement : CVariable
	{
		[Ordinal(0)]  [RED("componentsCollisionMapArray")] public CArray<questComponentCollisionMapArrayElement> ComponentsCollisionMapArray { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questNodeCollisionMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
