using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorOrbit : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _offset;
		private CHandle<IEvaluatorVector> _frequency;
		private CHandle<IEvaluatorVector> _phase;
		private CBool _overridePosition;

		[Ordinal(4)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get => GetProperty(ref _frequency);
			set => SetProperty(ref _frequency, value);
		}

		[Ordinal(6)] 
		[RED("phase")] 
		public CHandle<IEvaluatorVector> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(7)] 
		[RED("overridePosition")] 
		public CBool OverridePosition
		{
			get => GetProperty(ref _overridePosition);
			set => SetProperty(ref _overridePosition, value);
		}

		public CParticleModificatorOrbit(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
