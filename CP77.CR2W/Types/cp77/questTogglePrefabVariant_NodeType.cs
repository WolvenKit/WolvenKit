using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTogglePrefabVariant_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)]  [RED("params")] public CArray<questTogglePrefabVariant_NodeTypeParams> Params { get; set; }

		public questTogglePrefabVariant_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
