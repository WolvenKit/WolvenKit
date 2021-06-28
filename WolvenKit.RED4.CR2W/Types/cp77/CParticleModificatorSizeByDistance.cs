using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeByDistance : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _nearDistanceRangeStart;
		private CHandle<IEvaluatorFloat> _nearDistanceRangeEnd;
		private CHandle<IEvaluatorFloat> _nearDistanceSizeMultiplier;
		private CHandle<IEvaluatorFloat> _farDistanceRangeStart;
		private CHandle<IEvaluatorFloat> _farDistanceRangeEnd;
		private CHandle<IEvaluatorFloat> _farDistanceSizeMultiplier;

		[Ordinal(4)] 
		[RED("nearDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeStart
		{
			get => GetProperty(ref _nearDistanceRangeStart);
			set => SetProperty(ref _nearDistanceRangeStart, value);
		}

		[Ordinal(5)] 
		[RED("nearDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeEnd
		{
			get => GetProperty(ref _nearDistanceRangeEnd);
			set => SetProperty(ref _nearDistanceRangeEnd, value);
		}

		[Ordinal(6)] 
		[RED("nearDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier
		{
			get => GetProperty(ref _nearDistanceSizeMultiplier);
			set => SetProperty(ref _nearDistanceSizeMultiplier, value);
		}

		[Ordinal(7)] 
		[RED("farDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeStart
		{
			get => GetProperty(ref _farDistanceRangeStart);
			set => SetProperty(ref _farDistanceRangeStart, value);
		}

		[Ordinal(8)] 
		[RED("farDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeEnd
		{
			get => GetProperty(ref _farDistanceRangeEnd);
			set => SetProperty(ref _farDistanceRangeEnd, value);
		}

		[Ordinal(9)] 
		[RED("farDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier
		{
			get => GetProperty(ref _farDistanceSizeMultiplier);
			set => SetProperty(ref _farDistanceSizeMultiplier, value);
		}

		public CParticleModificatorSizeByDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
