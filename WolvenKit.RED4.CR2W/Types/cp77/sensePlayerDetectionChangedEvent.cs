using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sensePlayerDetectionChangedEvent : redEvent
	{
		private CFloat _oldDetectionValue;
		private CFloat _newDetectionValue;

		[Ordinal(0)] 
		[RED("oldDetectionValue")] 
		public CFloat OldDetectionValue
		{
			get
			{
				if (_oldDetectionValue == null)
				{
					_oldDetectionValue = (CFloat) CR2WTypeManager.Create("Float", "oldDetectionValue", cr2w, this);
				}
				return _oldDetectionValue;
			}
			set
			{
				if (_oldDetectionValue == value)
				{
					return;
				}
				_oldDetectionValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newDetectionValue")] 
		public CFloat NewDetectionValue
		{
			get
			{
				if (_newDetectionValue == null)
				{
					_newDetectionValue = (CFloat) CR2WTypeManager.Create("Float", "newDetectionValue", cr2w, this);
				}
				return _newDetectionValue;
			}
			set
			{
				if (_newDetectionValue == value)
				{
					return;
				}
				_newDetectionValue = value;
				PropertySet(this);
			}
		}

		public sensePlayerDetectionChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
