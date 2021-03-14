using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveConsumableDelayedEvent : redEvent
	{
		private CHandle<ConsumeAction> _consumeAction;

		[Ordinal(0)] 
		[RED("consumeAction")] 
		public CHandle<ConsumeAction> ConsumeAction
		{
			get
			{
				if (_consumeAction == null)
				{
					_consumeAction = (CHandle<ConsumeAction>) CR2WTypeManager.Create("handle:ConsumeAction", "consumeAction", cr2w, this);
				}
				return _consumeAction;
			}
			set
			{
				if (_consumeAction == value)
				{
					return;
				}
				_consumeAction = value;
				PropertySet(this);
			}
		}

		public RemoveConsumableDelayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
