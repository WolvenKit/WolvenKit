using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameUnequipByContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameItemUnequipContexts> _itemUnequipContext;

		[Ordinal(1)] 
		[RED("itemUnequipContext")] 
		public CEnum<gameItemUnequipContexts> ItemUnequipContext
		{
			get
			{
				if (_itemUnequipContext == null)
				{
					_itemUnequipContext = (CEnum<gameItemUnequipContexts>) CR2WTypeManager.Create("gameItemUnequipContexts", "itemUnequipContext", cr2w, this);
				}
				return _itemUnequipContext;
			}
			set
			{
				if (_itemUnequipContext == value)
				{
					return;
				}
				_itemUnequipContext = value;
				PropertySet(this);
			}
		}

		public gameUnequipByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
