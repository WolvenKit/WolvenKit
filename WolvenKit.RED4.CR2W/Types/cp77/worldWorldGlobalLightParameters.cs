using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightParameters : CVariable
	{
		private CEnum<ELightUnit> _unit;
		private curveData<HDRColor> _sunColor;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _sunSize;
		private curveData<CFloat> _moonSize;
		private curveData<HDRColor> _specularTint;

		[Ordinal(0)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get
			{
				if (_unit == null)
				{
					_unit = (CEnum<ELightUnit>) CR2WTypeManager.Create("ELightUnit", "unit", cr2w, this);
				}
				return _unit;
			}
			set
			{
				if (_unit == value)
				{
					return;
				}
				_unit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get
			{
				if (_sunColor == null)
				{
					_sunColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "sunColor", cr2w, this);
				}
				return _sunColor;
			}
			set
			{
				if (_sunColor == value)
				{
					return;
				}
				_sunColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get
			{
				if (_moonColor == null)
				{
					_moonColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "moonColor", cr2w, this);
				}
				return _moonColor;
			}
			set
			{
				if (_moonColor == value)
				{
					return;
				}
				_moonColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sunSize")] 
		public curveData<CFloat> SunSize
		{
			get
			{
				if (_sunSize == null)
				{
					_sunSize = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "sunSize", cr2w, this);
				}
				return _sunSize;
			}
			set
			{
				if (_sunSize == value)
				{
					return;
				}
				_sunSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("moonSize")] 
		public curveData<CFloat> MoonSize
		{
			get
			{
				if (_moonSize == null)
				{
					_moonSize = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonSize", cr2w, this);
				}
				return _moonSize;
			}
			set
			{
				if (_moonSize == value)
				{
					return;
				}
				_moonSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("specularTint")] 
		public curveData<HDRColor> SpecularTint
		{
			get
			{
				if (_specularTint == null)
				{
					_specularTint = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "specularTint", cr2w, this);
				}
				return _specularTint;
			}
			set
			{
				if (_specularTint == value)
				{
					return;
				}
				_specularTint = value;
				PropertySet(this);
			}
		}

		public worldWorldGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
