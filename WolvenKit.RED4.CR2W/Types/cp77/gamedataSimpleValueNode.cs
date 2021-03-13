using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataSimpleValueNode : gamedataValueDataNode
	{
		[Ordinal(3)] [RED("type")] public CEnum<gamedataSimpleValueNodeValueType> Type { get; set; }
		[Ordinal(4)] [RED("data")] public CString Data { get; set; }

		public gamedataSimpleValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
