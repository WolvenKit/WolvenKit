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
			get
			{
				if (_qualityLevel == null)
				{
					_qualityLevel = (CEnum<ConfigGraphicsQualityLevel>) CR2WTypeManager.Create("ConfigGraphicsQualityLevel", "QualityLevel", cr2w, this);
				}
				return _qualityLevel;
			}
			set
			{
				if (_qualityLevel == value)
				{
					return;
				}
				_qualityLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("xEntitiesBudget")] 
		public CUInt32 XEntitiesBudget
		{
			get
			{
				if (_xEntitiesBudget == null)
				{
					_xEntitiesBudget = (CUInt32) CR2WTypeManager.Create("Uint32", "xEntitiesBudget", cr2w, this);
				}
				return _xEntitiesBudget;
			}
			set
			{
				if (_xEntitiesBudget == value)
				{
					return;
				}
				_xEntitiesBudget = value;
				PropertySet(this);
			}
		}

		public worldQualitySetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
