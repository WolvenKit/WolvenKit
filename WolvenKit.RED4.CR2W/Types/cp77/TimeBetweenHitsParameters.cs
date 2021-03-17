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
			get => GetProperty(ref _baseCoefficient);
			set => SetProperty(ref _baseCoefficient, value);
		}

		[Ordinal(1)] 
		[RED("baseSourceCoefficient")] 
		public CFloat BaseSourceCoefficient
		{
			get => GetProperty(ref _baseSourceCoefficient);
			set => SetProperty(ref _baseSourceCoefficient, value);
		}

		[Ordinal(2)] 
		[RED("difficultyLevelCoefficient")] 
		public CFloat DifficultyLevelCoefficient
		{
			get => GetProperty(ref _difficultyLevelCoefficient);
			set => SetProperty(ref _difficultyLevelCoefficient, value);
		}

		[Ordinal(3)] 
		[RED("groupCoefficient")] 
		public CFloat GroupCoefficient
		{
			get => GetProperty(ref _groupCoefficient);
			set => SetProperty(ref _groupCoefficient, value);
		}

		[Ordinal(4)] 
		[RED("distanceCoefficient")] 
		public CFloat DistanceCoefficient
		{
			get => GetProperty(ref _distanceCoefficient);
			set => SetProperty(ref _distanceCoefficient, value);
		}

		[Ordinal(5)] 
		[RED("visibilityCoefficient")] 
		public CFloat VisibilityCoefficient
		{
			get => GetProperty(ref _visibilityCoefficient);
			set => SetProperty(ref _visibilityCoefficient, value);
		}

		[Ordinal(6)] 
		[RED("playersCountCoefficient")] 
		public CFloat PlayersCountCoefficient
		{
			get => GetProperty(ref _playersCountCoefficient);
			set => SetProperty(ref _playersCountCoefficient, value);
		}

		[Ordinal(7)] 
		[RED("coefficientMultiplier")] 
		public CFloat CoefficientMultiplier
		{
			get => GetProperty(ref _coefficientMultiplier);
			set => SetProperty(ref _coefficientMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("accuracyCoefficient")] 
		public CFloat AccuracyCoefficient
		{
			get => GetProperty(ref _accuracyCoefficient);
			set => SetProperty(ref _accuracyCoefficient, value);
		}

		public TimeBetweenHitsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
