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
			get
			{
				if (_tokenNodeRef == null)
				{
					_tokenNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "tokenNodeRef", cr2w, this);
				}
				return _tokenNodeRef;
			}
			set
			{
				if (_tokenNodeRef == value)
				{
					return;
				}
				_tokenNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lootTokenState")] 
		public CEnum<questLootTokenState> LootTokenState
		{
			get
			{
				if (_lootTokenState == null)
				{
					_lootTokenState = (CEnum<questLootTokenState>) CR2WTypeManager.Create("questLootTokenState", "lootTokenState", cr2w, this);
				}
				return _lootTokenState;
			}
			set
			{
				if (_lootTokenState == value)
				{
					return;
				}
				_lootTokenState = value;
				PropertySet(this);
			}
		}

		public questLootTokenManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
