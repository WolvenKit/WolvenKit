using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPuppetAIManagerNodeDefinitionEntry : CVariable
	{
		[Ordinal(0)]  [RED("aiTier")] public CEnum<gameStoryTier> AiTier { get; set; }
		[Ordinal(1)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }

		public questPuppetAIManagerNodeDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
