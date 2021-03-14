using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotationRate : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _rotationRate;

		[Ordinal(4)] 
		[RED("rotationRate")] 
		public CHandle<IEvaluatorFloat> RotationRate
		{
			get
			{
				if (_rotationRate == null)
				{
					_rotationRate = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "rotationRate", cr2w, this);
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

		public CParticleInitializerRotationRate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
