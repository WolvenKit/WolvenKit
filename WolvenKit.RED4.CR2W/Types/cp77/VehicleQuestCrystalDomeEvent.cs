using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestCrystalDomeEvent : redEvent
	{
		private CBool _toggle;
		private CBool _removeQuestControl;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get
			{
				if (_toggle == null)
				{
					_toggle = (CBool) CR2WTypeManager.Create("Bool", "toggle", cr2w, this);
				}
				return _toggle;
			}
			set
			{
				if (_toggle == value)
				{
					return;
				}
				_toggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("removeQuestControl")] 
		public CBool RemoveQuestControl
		{
			get
			{
				if (_removeQuestControl == null)
				{
					_removeQuestControl = (CBool) CR2WTypeManager.Create("Bool", "removeQuestControl", cr2w, this);
				}
				return _removeQuestControl;
			}
			set
			{
				if (_removeQuestControl == value)
				{
					return;
				}
				_removeQuestControl = value;
				PropertySet(this);
			}
		}

		public VehicleQuestCrystalDomeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
