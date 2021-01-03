using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Entity : questTimeDilation_NodeTypeParam
	{
		[Ordinal(0)]  [RED("entities")] public CArray<NodeRef> Entities { get; set; }
		[Ordinal(1)]  [RED("globalTimeDilationOverride")] public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride { get; set; }
		[Ordinal(2)]  [RED("operation")] public CHandle<questTimeDilation_Operation> Operation { get; set; }
		[Ordinal(3)]  [RED("parentTimeDilationOverride")] public CEnum<questETimeDilationOverride> ParentTimeDilationOverride { get; set; }

		public questTimeDilation_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
