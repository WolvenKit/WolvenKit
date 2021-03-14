using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _scale;
		private CBool _conserveMomentum;

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("conserveMomentum")] 
		public CBool ConserveMomentum
		{
			get
			{
				if (_conserveMomentum == null)
				{
					_conserveMomentum = (CBool) CR2WTypeManager.Create("Bool", "conserveMomentum", cr2w, this);
				}
				return _conserveMomentum;
			}
			set
			{
				if (_conserveMomentum == value)
				{
					return;
				}
				_conserveMomentum = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerVelocitySpread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
