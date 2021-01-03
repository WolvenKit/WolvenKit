using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedataVariableNode : gamedataDataNode
	{
		[Ordinal(0)]  [RED("hasArrayValues")] public CBool HasArrayValues { get; set; }
		[Ordinal(1)]  [RED("hashedName")] public CName HashedName { get; set; }
		[Ordinal(2)]  [RED("isAddition")] public CBool IsAddition { get; set; }
		[Ordinal(3)]  [RED("isArray")] public CBool IsArray { get; set; }
		[Ordinal(4)]  [RED("isForeignKey")] public CBool IsForeignKey { get; set; }
		[Ordinal(5)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(6)]  [RED("type")] public CString Type { get; set; }
		[Ordinal(7)]  [RED("typeEnum")] public CEnum<gamedataTweakDBType> TypeEnum { get; set; }
		[Ordinal(8)]  [RED("values")] public CArray<gamedataVariableNodeVariableValue> Values { get; set; }

		public gamedataVariableNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
