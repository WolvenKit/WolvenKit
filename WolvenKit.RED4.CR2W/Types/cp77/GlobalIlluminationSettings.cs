using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlobalIlluminationSettings : IAreaSettings
	{
		private curveData<CFloat> _multiBouceScale;
		private curveData<CFloat> _multiBouceSaturation;
		private curveData<CFloat> _emissiveScale;
		private curveData<CFloat> _diffuseScale;
		private curveData<CFloat> _localLightsScale;
		private curveData<CFloat> _lightScaleCompenensation;
		private curveData<CFloat> _reflectionCompensation;
		private curveData<HDRColor> _ambientBase;
		private curveData<CFloat> _rayTracedSkyRadianceScale;

		[Ordinal(2)] 
		[RED("multiBouceScale")] 
		public curveData<CFloat> MultiBouceScale
		{
			get
			{
				if (_multiBouceScale == null)
				{
					_multiBouceScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "multiBouceScale", cr2w, this);
				}
				return _multiBouceScale;
			}
			set
			{
				if (_multiBouceScale == value)
				{
					return;
				}
				_multiBouceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("multiBouceSaturation")] 
		public curveData<CFloat> MultiBouceSaturation
		{
			get
			{
				if (_multiBouceSaturation == null)
				{
					_multiBouceSaturation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "multiBouceSaturation", cr2w, this);
				}
				return _multiBouceSaturation;
			}
			set
			{
				if (_multiBouceSaturation == value)
				{
					return;
				}
				_multiBouceSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emissiveScale")] 
		public curveData<CFloat> EmissiveScale
		{
			get
			{
				if (_emissiveScale == null)
				{
					_emissiveScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "emissiveScale", cr2w, this);
				}
				return _emissiveScale;
			}
			set
			{
				if (_emissiveScale == value)
				{
					return;
				}
				_emissiveScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("diffuseScale")] 
		public curveData<CFloat> DiffuseScale
		{
			get
			{
				if (_diffuseScale == null)
				{
					_diffuseScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "diffuseScale", cr2w, this);
				}
				return _diffuseScale;
			}
			set
			{
				if (_diffuseScale == value)
				{
					return;
				}
				_diffuseScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("localLightsScale")] 
		public curveData<CFloat> LocalLightsScale
		{
			get
			{
				if (_localLightsScale == null)
				{
					_localLightsScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "localLightsScale", cr2w, this);
				}
				return _localLightsScale;
			}
			set
			{
				if (_localLightsScale == value)
				{
					return;
				}
				_localLightsScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lightScaleCompenensation")] 
		public curveData<CFloat> LightScaleCompenensation
		{
			get
			{
				if (_lightScaleCompenensation == null)
				{
					_lightScaleCompenensation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightScaleCompenensation", cr2w, this);
				}
				return _lightScaleCompenensation;
			}
			set
			{
				if (_lightScaleCompenensation == value)
				{
					return;
				}
				_lightScaleCompenensation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("reflectionCompensation")] 
		public curveData<CFloat> ReflectionCompensation
		{
			get
			{
				if (_reflectionCompensation == null)
				{
					_reflectionCompensation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "reflectionCompensation", cr2w, this);
				}
				return _reflectionCompensation;
			}
			set
			{
				if (_reflectionCompensation == value)
				{
					return;
				}
				_reflectionCompensation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ambientBase")] 
		public curveData<HDRColor> AmbientBase
		{
			get
			{
				if (_ambientBase == null)
				{
					_ambientBase = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "ambientBase", cr2w, this);
				}
				return _ambientBase;
			}
			set
			{
				if (_ambientBase == value)
				{
					return;
				}
				_ambientBase = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rayTracedSkyRadianceScale")] 
		public curveData<CFloat> RayTracedSkyRadianceScale
		{
			get
			{
				if (_rayTracedSkyRadianceScale == null)
				{
					_rayTracedSkyRadianceScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "rayTracedSkyRadianceScale", cr2w, this);
				}
				return _rayTracedSkyRadianceScale;
			}
			set
			{
				if (_rayTracedSkyRadianceScale == value)
				{
					return;
				}
				_rayTracedSkyRadianceScale = value;
				PropertySet(this);
			}
		}

		public GlobalIlluminationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
