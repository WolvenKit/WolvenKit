using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HeatHazeAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _effectStrength;
		private curveData<CFloat> _startDistance;
		private curveData<CFloat> _maxDistance;
		private curveData<CFloat> _patternScale;
		private curveData<CFloat> _movementSpeedScale;

		[Ordinal(2)] 
		[RED("effectStrength")] 
		public curveData<CFloat> EffectStrength
		{
			get
			{
				if (_effectStrength == null)
				{
					_effectStrength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "effectStrength", cr2w, this);
				}
				return _effectStrength;
			}
			set
			{
				if (_effectStrength == value)
				{
					return;
				}
				_effectStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startDistance")] 
		public curveData<CFloat> StartDistance
		{
			get
			{
				if (_startDistance == null)
				{
					_startDistance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "startDistance", cr2w, this);
				}
				return _startDistance;
			}
			set
			{
				if (_startDistance == value)
				{
					return;
				}
				_startDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public curveData<CFloat> MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("patternScale")] 
		public curveData<CFloat> PatternScale
		{
			get
			{
				if (_patternScale == null)
				{
					_patternScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "patternScale", cr2w, this);
				}
				return _patternScale;
			}
			set
			{
				if (_patternScale == value)
				{
					return;
				}
				_patternScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("movementSpeedScale")] 
		public curveData<CFloat> MovementSpeedScale
		{
			get
			{
				if (_movementSpeedScale == null)
				{
					_movementSpeedScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "movementSpeedScale", cr2w, this);
				}
				return _movementSpeedScale;
			}
			set
			{
				if (_movementSpeedScale == value)
				{
					return;
				}
				_movementSpeedScale = value;
				PropertySet(this);
			}
		}

		public HeatHazeAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
