using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAudioEvent : redEvent
	{
		private CEnum<vehicleAudioEventAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleAudioEventAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<vehicleAudioEventAction>) CR2WTypeManager.Create("vehicleAudioEventAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public vehicleAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
