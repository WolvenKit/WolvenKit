using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotation3D : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _rotation;

		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorVector> Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		public CParticleInitializerRotation3D(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
