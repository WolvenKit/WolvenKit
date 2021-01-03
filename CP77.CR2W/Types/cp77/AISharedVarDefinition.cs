using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AISharedVarDefinition : CVariable
	{
		[Ordinal(0)]  [RED("name")] public LibTreeSharedVarRegistrationName Name { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<AIESharedVarDefinitionType> Type { get; set; }

		public AISharedVarDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
