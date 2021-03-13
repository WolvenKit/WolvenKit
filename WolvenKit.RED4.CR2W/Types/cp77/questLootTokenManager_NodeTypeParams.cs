using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLootTokenManager_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("tokenNodeRef")] public NodeRef TokenNodeRef { get; set; }
		[Ordinal(1)] [RED("lootTokenState")] public CEnum<questLootTokenState> LootTokenState { get; set; }

		public questLootTokenManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
