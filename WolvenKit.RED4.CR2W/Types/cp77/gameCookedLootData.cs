using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedLootData : ISerializable
	{
		[Ordinal(0)] [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }
		[Ordinal(1)] [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }

		public gameCookedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
