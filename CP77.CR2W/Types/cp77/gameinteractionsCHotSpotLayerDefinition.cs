using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotLayerDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)]  [RED("areaFilterDefinition")] public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("gameLogicFilterDefinition")] public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition { get; set; }
		[Ordinal(3)]  [RED("group")] public CEnum<gameinteractionsEGroupType> Group { get; set; }
		[Ordinal(4)]  [RED("priorityMultiplier")] public CFloat PriorityMultiplier { get; set; }
		[Ordinal(5)]  [RED("tag")] public CName Tag { get; set; }

		public gameinteractionsCHotSpotLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
