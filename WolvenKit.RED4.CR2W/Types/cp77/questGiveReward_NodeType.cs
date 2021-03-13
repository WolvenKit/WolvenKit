using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGiveReward_NodeType : questIRewardManagerNodeType
	{
		[Ordinal(0)] [RED("rewards")] public CArray<TweakDBID> Rewards { get; set; }

		public questGiveReward_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
