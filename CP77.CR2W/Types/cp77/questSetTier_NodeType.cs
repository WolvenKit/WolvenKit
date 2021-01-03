using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetTier_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("forceEmptyHands")] public CBool ForceEmptyHands { get; set; }
		[Ordinal(1)]  [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }
		[Ordinal(2)]  [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(3)]  [RED("useExitAnim")] public CBool UseExitAnim { get; set; }
		[Ordinal(4)]  [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }

		public questSetTier_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
