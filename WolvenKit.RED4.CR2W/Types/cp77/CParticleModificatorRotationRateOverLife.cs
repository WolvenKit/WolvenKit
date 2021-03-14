using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRateOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _rotationRate;
		private CBool _modulate;

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

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get
			{
				if (_modulate == null)
				{
					_modulate = (CBool) CR2WTypeManager.Create("Bool", "modulate", cr2w, this);
				}
				return _modulate;
			}
			set
			{
				if (_modulate == value)
				{
					return;
				}
				_modulate = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorRotationRateOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
