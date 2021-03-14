using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		private CBool _initiated;
		private CBool _itemSwitched;

		[Ordinal(0)] 
		[RED("initiated")] 
		public CBool Initiated
		{
			get
			{
				if (_initiated == null)
				{
					_initiated = (CBool) CR2WTypeManager.Create("Bool", "initiated", cr2w, this);
				}
				return _initiated;
			}
			set
			{
				if (_initiated == value)
				{
					return;
				}
				_initiated = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemSwitched")] 
		public CBool ItemSwitched
		{
			get
			{
				if (_itemSwitched == null)
				{
					_itemSwitched = (CBool) CR2WTypeManager.Create("Bool", "itemSwitched", cr2w, this);
				}
				return _itemSwitched;
			}
			set
			{
				if (_itemSwitched == value)
				{
					return;
				}
				_itemSwitched = value;
				PropertySet(this);
			}
		}

		public CombatGadgetChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
