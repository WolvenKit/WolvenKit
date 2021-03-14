using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlideEvents : CrouchEvents
	{
		private CBool _rumblePlayed;
		private CHandle<gameStatModifierData> _addDecelerationModifier;

		[Ordinal(0)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get
			{
				if (_rumblePlayed == null)
				{
					_rumblePlayed = (CBool) CR2WTypeManager.Create("Bool", "rumblePlayed", cr2w, this);
				}
				return _rumblePlayed;
			}
			set
			{
				if (_rumblePlayed == value)
				{
					return;
				}
				_rumblePlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData> AddDecelerationModifier
		{
			get
			{
				if (_addDecelerationModifier == null)
				{
					_addDecelerationModifier = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "addDecelerationModifier", cr2w, this);
				}
				return _addDecelerationModifier;
			}
			set
			{
				if (_addDecelerationModifier == value)
				{
					return;
				}
				_addDecelerationModifier = value;
				PropertySet(this);
			}
		}

		public SlideEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
