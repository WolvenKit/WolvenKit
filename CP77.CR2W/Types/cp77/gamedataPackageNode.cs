using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedataPackageNode : ISerializable
	{
		[Ordinal(0)]  [RED("files")] public CArray<CHandle<gamedataFileNode>> Files { get; set; }
		[Ordinal(1)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(2)]  [RED("serializedGroups")] public CArray<CHandle<gamedataGroupNode>> SerializedGroups { get; set; }
		[Ordinal(3)]  [RED("serializedVariables")] public CArray<CHandle<gamedataVariableNode>> SerializedVariables { get; set; }

		public gamedataPackageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
