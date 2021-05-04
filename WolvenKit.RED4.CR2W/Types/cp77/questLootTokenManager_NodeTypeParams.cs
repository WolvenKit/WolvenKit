using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLootTokenManager_NodeTypeParams : CVariable
	{
		private NodeRef _tokenNodeRef;
		private CEnum<questLootTokenState> _lootTokenState;

		[Ordinal(0)] 
		[RED("tokenNodeRef")] 
		public NodeRef TokenNodeRef
		{
			get => GetProperty(ref _tokenNodeRef);
			set => SetProperty(ref _tokenNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("lootTokenState")] 
		public CEnum<questLootTokenState> LootTokenState
		{
			get => GetProperty(ref _lootTokenState);
			set => SetProperty(ref _lootTokenState, value);
		}

		public questLootTokenManager_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
