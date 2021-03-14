using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<ItemInSlotPrereqState> _state;

		[Ordinal(2)] 
		[RED("state")] 
		public wCHandle<ItemInSlotPrereqState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (wCHandle<ItemInSlotPrereqState>) CR2WTypeManager.Create("whandle:ItemInSlotPrereqState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public ItemInSlotCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
