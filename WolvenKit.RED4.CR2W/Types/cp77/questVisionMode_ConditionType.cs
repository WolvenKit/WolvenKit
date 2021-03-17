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
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<questVisionModeType> VisionModeType
		{
			get => GetProperty(ref _visionModeType);
			set => SetProperty(ref _visionModeType, value);
		}

		public questVisionMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
