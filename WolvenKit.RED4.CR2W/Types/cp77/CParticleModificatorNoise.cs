using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorNoise : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _amplitude;
		private CHandle<IEvaluatorVector> _offset;
		private CHandle<IEvaluatorVector> _frequency;
		private Vector3 _changeRate;
		private CBool _applyToPosition;
		private CBool _worldSpaceOffset;
		private CEnum<ENoiseType> _noiseType;

		[Ordinal(4)] 
		[RED("amplitude")] 
		public CHandle<IEvaluatorVector> Amplitude
		{
			get => GetProperty(ref _amplitude);
			set => SetProperty(ref _amplitude, value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get => GetProperty(ref _frequency);
			set => SetProperty(ref _frequency, value);
		}

		[Ordinal(7)] 
		[RED("changeRate")] 
		public Vector3 ChangeRate
		{
			get => GetProperty(ref _changeRate);
			set => SetProperty(ref _changeRate, value);
		}

		[Ordinal(8)] 
		[RED("applyToPosition")] 
		public CBool ApplyToPosition
		{
			get => GetProperty(ref _applyToPosition);
			set => SetProperty(ref _applyToPosition, value);
		}

		[Ordinal(9)] 
		[RED("worldSpaceOffset")] 
		public CBool WorldSpaceOffset
		{
			get => GetProperty(ref _worldSpaceOffset);
			set => SetProperty(ref _worldSpaceOffset, value);
		}

		[Ordinal(10)] 
		[RED("noiseType")] 
		public CEnum<ENoiseType> NoiseType
		{
			get => GetProperty(ref _noiseType);
			set => SetProperty(ref _noiseType, value);
		}

		public CParticleModificatorNoise(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
