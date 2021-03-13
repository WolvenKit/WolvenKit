using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataPackageNode : ISerializable
	{
		[Ordinal(0)] [RED("name")] public CString Name { get; set; }
		[Ordinal(1)] [RED("serializedVariables")] public CArray<CHandle<gamedataVariableNode>> SerializedVariables { get; set; }
		[Ordinal(2)] [RED("serializedGroups")] public CArray<CHandle<gamedataGroupNode>> SerializedGroups { get; set; }
		[Ordinal(3)] [RED("files")] public CArray<CHandle<gamedataFileNode>> Files { get; set; }

		public gamedataPackageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
