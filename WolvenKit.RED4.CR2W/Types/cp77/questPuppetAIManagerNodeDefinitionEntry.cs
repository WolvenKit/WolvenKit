using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetAIManagerNodeDefinitionEntry : CVariable
	{
		[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
		[Ordinal(1)] [RED("aiTier")] public CEnum<gameStoryTier> AiTier { get; set; }

		public questPuppetAIManagerNodeDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
