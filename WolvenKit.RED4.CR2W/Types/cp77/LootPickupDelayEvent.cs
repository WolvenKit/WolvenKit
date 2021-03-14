using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootPickupDelayEvent : redEvent
	{
		private CBool _enableLootInteraction;

		[Ordinal(0)] 
		[RED("enableLootInteraction")] 
		public CBool EnableLootInteraction
		{
			get
			{
				if (_enableLootInteraction == null)
				{
					_enableLootInteraction = (CBool) CR2WTypeManager.Create("Bool", "enableLootInteraction", cr2w, this);
				}
				return _enableLootInteraction;
			}
			set
			{
				if (_enableLootInteraction == value)
				{
					return;
				}
				_enableLootInteraction = value;
				PropertySet(this);
			}
		}

		public LootPickupDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
