using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotationRate3D : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _rotationRate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorVector> RotationRate
		{
			get
			{
				if (_rotationRate == null)
				{
					_rotationRate = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "rotationRate", cr2w, this);
				}
				return _rotationRate;
			}
			set
			{
				if (_rotationRate == value)
				{
					return;
				}
				_rotationRate = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerRotationRate3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
