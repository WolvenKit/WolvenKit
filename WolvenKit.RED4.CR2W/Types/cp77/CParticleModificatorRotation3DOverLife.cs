using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotation3DOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _rotation;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorVector> Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetProperty(ref _modulate);
			set => SetProperty(ref _modulate, value);
		}

		public CParticleModificatorRotation3DOverLife(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
