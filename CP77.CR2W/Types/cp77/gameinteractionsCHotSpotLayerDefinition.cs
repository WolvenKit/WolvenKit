using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotLayerDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)]  [RED("group")] public CEnum<gameinteractionsEGroupType> Group { get; set; }
		[Ordinal(3)]  [RED("priorityMultiplier")] public CFloat PriorityMultiplier { get; set; }
		[Ordinal(4)]  [RED("areaFilterDefinition")] public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition { get; set; }
		[Ordinal(5)]  [RED("gameLogicFilterDefinition")] public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition { get; set; }

		public gameinteractionsCHotSpotLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
