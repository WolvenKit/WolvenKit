using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeHideEvent : redEvent
	{
		private CBool _hide;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get
			{
				if (_hide == null)
				{
					_hide = (CBool) CR2WTypeManager.Create("Bool", "hide", cr2w, this);
				}
				return _hide;
			}
			set
			{
				if (_hide == value)
				{
					return;
				}
				_hide = value;
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

		public gameVisionModeHideEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
