using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataVariableNode : gamedataDataNode
	{
		[Ordinal(3)] [RED("hashedName")] public CName HashedName { get; set; }
		[Ordinal(4)] [RED("type")] public CString Type { get; set; }
		[Ordinal(5)] [RED("name")] public CString Name { get; set; }
		[Ordinal(6)] [RED("isForeignKey")] public CBool IsForeignKey { get; set; }
		[Ordinal(7)] [RED("isArray")] public CBool IsArray { get; set; }
		[Ordinal(8)] [RED("hasArrayValues")] public CBool HasArrayValues { get; set; }
		[Ordinal(9)] [RED("isAddition")] public CBool IsAddition { get; set; }
		[Ordinal(10)] [RED("typeEnum")] public CEnum<gamedataTweakDBType> TypeEnum { get; set; }
		[Ordinal(11)] [RED("values")] public CArray<gamedataVariableNodeVariableValue> Values { get; set; }

		public gamedataVariableNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
