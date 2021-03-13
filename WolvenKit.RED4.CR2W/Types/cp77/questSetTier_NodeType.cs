using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }
		[Ordinal(1)] [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }
		[Ordinal(2)] [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(3)] [RED("useExitAnim")] public CBool UseExitAnim { get; set; }
		[Ordinal(4)] [RED("forceEmptyHands")] public CBool ForceEmptyHands { get; set; }

		public questSetTier_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
