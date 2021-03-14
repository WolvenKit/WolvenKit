using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayItemCondition : GameplayConditionBase
	{
		private TweakDBID _itemToCheck;

		[Ordinal(1)] 
		[RED("itemToCheck")] 
		public TweakDBID ItemToCheck
		{
			get
			{
				if (_itemToCheck == null)
				{
					_itemToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemToCheck", cr2w, this);
				}
				return _itemToCheck;
			}
			set
			{
				if (_itemToCheck == value)
				{
					return;
				}
				_itemToCheck = value;
				PropertySet(this);
			}
		}

		public GameplayItemCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
