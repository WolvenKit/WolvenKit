using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPlant : animAnimEvent
	{
		private CEnum<animEventSide> _side;
		private CName _customEvent;

		[Ordinal(3)] 
		[RED("side")] 
		public CEnum<animEventSide> Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CEnum<animEventSide>) CR2WTypeManager.Create("animEventSide", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customEvent")] 
		public CName CustomEvent
		{
			get
			{
				if (_customEvent == null)
				{
					_customEvent = (CName) CR2WTypeManager.Create("CName", "customEvent", cr2w, this);
				}
				return _customEvent;
			}
			set
			{
				if (_customEvent == value)
				{
					return;
				}
				_customEvent = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_FootPlant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
