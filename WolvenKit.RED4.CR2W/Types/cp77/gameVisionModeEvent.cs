using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeEvent : redEvent
	{
		private CBool _activated;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("activated")] 
		public CBool Activated
		{
			get
			{
				if (_activated == null)
				{
					_activated = (CBool) CR2WTypeManager.Create("Bool", "activated", cr2w, this);
				}
				return _activated;
			}
			set
			{
				if (_activated == value)
				{
					return;
				}
				_activated = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameVisionModeType>) CR2WTypeManager.Create("gameVisionModeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameVisionModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
