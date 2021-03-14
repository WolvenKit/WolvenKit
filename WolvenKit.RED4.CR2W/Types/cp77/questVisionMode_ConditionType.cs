using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVisionMode_ConditionType : questISystemConditionType
	{
		private CFloat _timeInterval;
		private CEnum<questVisionModeType> _visionModeType;

		[Ordinal(0)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get
			{
				if (_timeInterval == null)
				{
					_timeInterval = (CFloat) CR2WTypeManager.Create("Float", "timeInterval", cr2w, this);
				}
				return _timeInterval;
			}
			set
			{
				if (_timeInterval == value)
				{
					return;
				}
				_timeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<questVisionModeType> VisionModeType
		{
			get
			{
				if (_visionModeType == null)
				{
					_visionModeType = (CEnum<questVisionModeType>) CR2WTypeManager.Create("questVisionModeType", "visionModeType", cr2w, this);
				}
				return _visionModeType;
			}
			set
			{
				if (_visionModeType == value)
				{
					return;
				}
				_visionModeType = value;
				PropertySet(this);
			}
		}

		public questVisionMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
