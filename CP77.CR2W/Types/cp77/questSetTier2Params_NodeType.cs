using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetTier2Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("playerWalkType")] public CEnum<Tier2WalkType> PlayerWalkType { get; set; }
		[Ordinal(1)]  [RED("useEnterAnim")] public CBool UseEnterAnim { get; set; }
		[Ordinal(2)]  [RED("useExitAnim")] public CBool UseExitAnim { get; set; }
		[Ordinal(3)]  [RED("usePlayerWorkspot")] public CBool UsePlayerWorkspot { get; set; }

		public questSetTier2Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
