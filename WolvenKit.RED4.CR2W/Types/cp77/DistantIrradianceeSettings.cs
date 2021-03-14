using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantIrradianceeSettings : IAreaSettings
	{
		private curveData<Vector2> _distantRange;
		private curveData<Vector3> _distantHeightRange;
		private curveData<CFloat> _distantLights;
		private curveData<Vector2> _distantLightsRange;
		private curveData<CFloat> _blendDistance;

		[Ordinal(2)] 
		[RED("distantRange")] 
		public curveData<Vector2> DistantRange
		{
			get
			{
				if (_distantRange == null)
				{
					_distantRange = (curveData<Vector2>) CR2WTypeManager.Create("curveData:Vector2", "distantRange", cr2w, this);
				}
				return _distantRange;
			}
			set
			{
				if (_distantRange == value)
				{
					return;
				}
				_distantRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distantHeightRange")] 
		public curveData<Vector3> DistantHeightRange
		{
			get
			{
				if (_distantHeightRange == null)
				{
					_distantHeightRange = (curveData<Vector3>) CR2WTypeManager.Create("curveData:Vector3", "distantHeightRange", cr2w, this);
				}
				return _distantHeightRange;
			}
			set
			{
				if (_distantHeightRange == value)
				{
					return;
				}
				_distantHeightRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distantLights")] 
		public curveData<CFloat> DistantLights
		{
			get
			{
				if (_distantLights == null)
				{
					_distantLights = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "distantLights", cr2w, this);
				}
				return _distantLights;
			}
			set
			{
				if (_distantLights == value)
				{
					return;
				}
				_distantLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distantLightsRange")] 
		public curveData<Vector2> DistantLightsRange
		{
			get
			{
				if (_distantLightsRange == null)
				{
					_distantLightsRange = (curveData<Vector2>) CR2WTypeManager.Create("curveData:Vector2", "distantLightsRange", cr2w, this);
				}
				return _distantLightsRange;
			}
			set
			{
				if (_distantLightsRange == value)
				{
					return;
				}
				_distantLightsRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blendDistance")] 
		public curveData<CFloat> BlendDistance
		{
			get
			{
				if (_blendDistance == null)
				{
					_blendDistance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "blendDistance", cr2w, this);
				}
				return _blendDistance;
			}
			set
			{
				if (_blendDistance == value)
				{
					return;
				}
				_blendDistance = value;
				PropertySet(this);
			}
		}

		public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
