using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animVectorLink : CVariable
	{
		[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_VectorValue> Node { get; set; }

		public animVectorLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
