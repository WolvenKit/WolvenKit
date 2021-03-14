using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFootPlantedEvent : redEvent
	{
		private CName _customAction;
		private CEnum<animEventSide> _footSide;

		[Ordinal(0)] 
		[RED("customAction")] 
		public CName CustomAction
		{
			get
			{
				if (_customAction == null)
				{
					_customAction = (CName) CR2WTypeManager.Create("CName", "customAction", cr2w, this);
				}
				return _customAction;
			}
			set
			{
				if (_customAction == value)
				{
					return;
				}
				_customAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("footSide")] 
		public CEnum<animEventSide> FootSide
		{
			get
			{
				if (_footSide == null)
				{
					_footSide = (CEnum<animEventSide>) CR2WTypeManager.Create("animEventSide", "footSide", cr2w, this);
				}
				return _footSide;
			}
			set
			{
				if (_footSide == value)
				{
					return;
				}
				_footSide = value;
				PropertySet(this);
			}
		}

		public entFootPlantedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
