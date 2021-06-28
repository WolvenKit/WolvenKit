using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldQualitySetting : CVariable
	{
		private CEnum<ConfigGraphicsQualityLevel> _qualityLevel;
		private CUInt32 _xEntitiesBudget;

		[Ordinal(0)] 
		[RED("QualityLevel")] 
		public CEnum<ConfigGraphicsQualityLevel> QualityLevel
		{
			get => GetProperty(ref _qualityLevel);
			set => SetProperty(ref _qualityLevel, value);
		}

		[Ordinal(1)] 
		[RED("xEntitiesBudget")] 
		public CUInt32 XEntitiesBudget
		{
			get => GetProperty(ref _xEntitiesBudget);
			set => SetProperty(ref _xEntitiesBudget, value);
		}

		public worldQualitySetting(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
