using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDrag : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _dragCoefficient;
		private CFloat _scale;

		[Ordinal(4)] 
		[RED("dragCoefficient")] 
		public CHandle<IEvaluatorFloat> DragCoefficient
		{
			get => GetProperty(ref _dragCoefficient);
			set => SetProperty(ref _dragCoefficient, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		public CParticleModificatorDrag(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
