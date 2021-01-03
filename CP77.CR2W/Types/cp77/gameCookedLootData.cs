using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCookedLootData : ISerializable
	{
		[Ordinal(0)]  [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }
		[Ordinal(1)]  [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }

		public gameCookedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
