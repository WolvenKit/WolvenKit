using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterItemUsedRequest : gameScriptableSystemRequest
	{
		private gameItemID _itemUsed;

		[Ordinal(0)] 
		[RED("itemUsed")] 
		public gameItemID ItemUsed
		{
			get
			{
				if (_itemUsed == null)
				{
					_itemUsed = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemUsed", cr2w, this);
				}
				return _itemUsed;
			}
			set
			{
				if (_itemUsed == value)
				{
					return;
				}
				_itemUsed = value;
				PropertySet(this);
			}
		}

		public RegisterItemUsedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
