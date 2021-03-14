using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeBetweenHitsParameters : CVariable
	{
		private CFloat _baseCoefficient;
		private CFloat _baseSourceCoefficient;
		private CFloat _difficultyLevelCoefficient;
		private CFloat _groupCoefficient;
		private CFloat _distanceCoefficient;
		private CFloat _visibilityCoefficient;
		private CFloat _playersCountCoefficient;
		private CFloat _coefficientMultiplier;
		private CFloat _accuracyCoefficient;

		[Ordinal(0)] 
		[RED("baseCoefficient")] 
		public CFloat BaseCoefficient
		{
			get
			{
				if (_baseCoefficient == null)
				{
					_baseCoefficient = (CFloat) CR2WTypeManager.Create("Float", "baseCoefficient", cr2w, this);
				}
				return _baseCoefficient;
			}
			set
			{
				if (_baseCoefficient == value)
				{
					return;
				}
				_baseCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("baseSourceCoefficient")] 
		public CFloat BaseSourceCoefficient
		{
			get
			{
				if (_baseSourceCoefficient == null)
				{
					_baseSourceCoefficient = (CFloat) CR2WTypeManager.Create("Float", "baseSourceCoefficient", cr2w, this);
				}
				return _baseSourceCoefficient;
			}
			set
			{
				if (_baseSourceCoefficient == value)
				{
					return;
				}
				_baseSourceCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("difficultyLevelCoefficient")] 
		public CFloat DifficultyLevelCoefficient
		{
			get
			{
				if (_difficultyLevelCoefficient == null)
				{
					_difficultyLevelCoefficient = (CFloat) CR2WTypeManager.Create("Float", "difficultyLevelCoefficient", cr2w, this);
				}
				return _difficultyLevelCoefficient;
			}
			set
			{
				if (_difficultyLevelCoefficient == value)
				{
					return;
				}
				_difficultyLevelCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("groupCoefficient")] 
		public CFloat GroupCoefficient
		{
			get
			{
				if (_groupCoefficient == null)
				{
					_groupCoefficient = (CFloat) CR2WTypeManager.Create("Float", "groupCoefficient", cr2w, this);
				}
				return _groupCoefficient;
			}
			set
			{
				if (_groupCoefficient == value)
				{
					return;
				}
				_groupCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distanceCoefficient")] 
		public CFloat DistanceCoefficient
		{
			get
			{
				if (_distanceCoefficient == null)
				{
					_distanceCoefficient = (CFloat) CR2WTypeManager.Create("Float", "distanceCoefficient", cr2w, this);
				}
				return _distanceCoefficient;
			}
			set
			{
				if (_distanceCoefficient == value)
				{
					return;
				}
				_distanceCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("visibilityCoefficient")] 
		public CFloat VisibilityCoefficient
		{
			get
			{
				if (_visibilityCoefficient == null)
				{
					_visibilityCoefficient = (CFloat) CR2WTypeManager.Create("Float", "visibilityCoefficient", cr2w, this);
				}
				return _visibilityCoefficient;
			}
			set
			{
				if (_visibilityCoefficient == value)
				{
					return;
				}
				_visibilityCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playersCountCoefficient")] 
		public CFloat PlayersCountCoefficient
		{
			get
			{
				if (_playersCountCoefficient == null)
				{
					_playersCountCoefficient = (CFloat) CR2WTypeManager.Create("Float", "playersCountCoefficient", cr2w, this);
				}
				return _playersCountCoefficient;
			}
			set
			{
				if (_playersCountCoefficient == value)
				{
					return;
				}
				_playersCountCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("coefficientMultiplier")] 
		public CFloat CoefficientMultiplier
		{
			get
			{
				if (_coefficientMultiplier == null)
				{
					_coefficientMultiplier = (CFloat) CR2WTypeManager.Create("Float", "coefficientMultiplier", cr2w, this);
				}
				return _coefficientMultiplier;
			}
			set
			{
				if (_coefficientMultiplier == value)
				{
					return;
				}
				_coefficientMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("accuracyCoefficient")] 
		public CFloat AccuracyCoefficient
		{
			get
			{
				if (_accuracyCoefficient == null)
				{
					_accuracyCoefficient = (CFloat) CR2WTypeManager.Create("Float", "accuracyCoefficient", cr2w, this);
				}
				return _accuracyCoefficient;
			}
			set
			{
				if (_accuracyCoefficient == value)
				{
					return;
				}
				_accuracyCoefficient = value;
				PropertySet(this);
			}
		}

		public TimeBetweenHitsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
