using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RTAOAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _rangeNear;
		private curveData<CFloat> _rangeFar;
		private curveData<CFloat> _radiusNear;
		private curveData<CFloat> _radiusFar;
		private curveData<CFloat> _coneAoDiffuseStrength;
		private curveData<CFloat> _coneAoSpecularStrength;
		private curveData<CFloat> _coneAoSpecularTreshold;
		private curveData<CFloat> _lightAoDiffuseStrength;
		private curveData<CFloat> _lightAoSpecularStrength;

		[Ordinal(2)] 
		[RED("RangeNear")] 
		public curveData<CFloat> RangeNear
		{
			get
			{
				if (_rangeNear == null)
				{
					_rangeNear = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "RangeNear", cr2w, this);
				}
				return _rangeNear;
			}
			set
			{
				if (_rangeNear == value)
				{
					return;
				}
				_rangeNear = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("RangeFar")] 
		public curveData<CFloat> RangeFar
		{
			get
			{
				if (_rangeFar == null)
				{
					_rangeFar = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "RangeFar", cr2w, this);
				}
				return _rangeFar;
			}
			set
			{
				if (_rangeFar == value)
				{
					return;
				}
				_rangeFar = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("RadiusNear")] 
		public curveData<CFloat> RadiusNear
		{
			get
			{
				if (_radiusNear == null)
				{
					_radiusNear = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "RadiusNear", cr2w, this);
				}
				return _radiusNear;
			}
			set
			{
				if (_radiusNear == value)
				{
					return;
				}
				_radiusNear = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("RadiusFar")] 
		public curveData<CFloat> RadiusFar
		{
			get
			{
				if (_radiusFar == null)
				{
					_radiusFar = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "RadiusFar", cr2w, this);
				}
				return _radiusFar;
			}
			set
			{
				if (_radiusFar == value)
				{
					return;
				}
				_radiusFar = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("coneAoDiffuseStrength")] 
		public curveData<CFloat> ConeAoDiffuseStrength
		{
			get
			{
				if (_coneAoDiffuseStrength == null)
				{
					_coneAoDiffuseStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoDiffuseStrength", cr2w, this);
				}
				return _coneAoDiffuseStrength;
			}
			set
			{
				if (_coneAoDiffuseStrength == value)
				{
					return;
				}
				_coneAoDiffuseStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("coneAoSpecularStrength")] 
		public curveData<CFloat> ConeAoSpecularStrength
		{
			get
			{
				if (_coneAoSpecularStrength == null)
				{
					_coneAoSpecularStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoSpecularStrength", cr2w, this);
				}
				return _coneAoSpecularStrength;
			}
			set
			{
				if (_coneAoSpecularStrength == value)
				{
					return;
				}
				_coneAoSpecularStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("coneAoSpecularTreshold")] 
		public curveData<CFloat> ConeAoSpecularTreshold
		{
			get
			{
				if (_coneAoSpecularTreshold == null)
				{
					_coneAoSpecularTreshold = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "coneAoSpecularTreshold", cr2w, this);
				}
				return _coneAoSpecularTreshold;
			}
			set
			{
				if (_coneAoSpecularTreshold == value)
				{
					return;
				}
				_coneAoSpecularTreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lightAoDiffuseStrength")] 
		public curveData<CFloat> LightAoDiffuseStrength
		{
			get
			{
				if (_lightAoDiffuseStrength == null)
				{
					_lightAoDiffuseStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightAoDiffuseStrength", cr2w, this);
				}
				return _lightAoDiffuseStrength;
			}
			set
			{
				if (_lightAoDiffuseStrength == value)
				{
					return;
				}
				_lightAoDiffuseStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lightAoSpecularStrength")] 
		public curveData<CFloat> LightAoSpecularStrength
		{
			get
			{
				if (_lightAoSpecularStrength == null)
				{
					_lightAoSpecularStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "lightAoSpecularStrength", cr2w, this);
				}
				return _lightAoSpecularStrength;
			}
			set
			{
				if (_lightAoSpecularStrength == value)
				{
					return;
				}
				_lightAoSpecularStrength = value;
				PropertySet(this);
			}
		}

		public RTAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
