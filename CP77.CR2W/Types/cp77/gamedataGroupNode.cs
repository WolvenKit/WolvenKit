using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedataGroupNode : gamedataDataNode
	{
		[Ordinal(0)]  [RED("base")] public CString Base { get; set; }
		[Ordinal(1)]  [RED("baseGroup")] public wCHandle<gamedataGroupNode> BaseGroup { get; set; }
		[Ordinal(2)]  [RED("fileNode")] public CHandle<gamedataFileNode> FileNode { get; set; }
		[Ordinal(3)]  [RED("inheritanceState")] public CEnum<gamedataGroupNodeInheritanceState> InheritanceState { get; set; }
		[Ordinal(4)]  [RED("inlineGroupId")] public CUInt32 InlineGroupId { get; set; }
		[Ordinal(5)]  [RED("isInline")] public CBool IsInline { get; set; }
		[Ordinal(6)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(7)]  [RED("package")] public wCHandle<gamedataPackageNode> Package { get; set; }
		[Ordinal(8)]  [RED("schema")] public CString Schema { get; set; }
		[Ordinal(9)]  [RED("schemaGroup")] public wCHandle<gamedataGroupNode> SchemaGroup { get; set; }
		[Ordinal(10)]  [RED("serializedVariables")] public CArray<gamedataGroupNodeGroupVariable> SerializedVariables { get; set; }
		[Ordinal(11)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public gamedataGroupNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
