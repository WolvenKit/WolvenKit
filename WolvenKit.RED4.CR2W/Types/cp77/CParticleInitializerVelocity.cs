using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocity : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _velocity;
		private CFloat _scale;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("velocity")] 
		public CHandle<IEvaluatorVector> Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "velocity", cr2w, this);
				}
				return _velocity;
			}
			set
			{
				if (_velocity == value)
				{
					return;
				}
				_velocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
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

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get
			{
				if (_worldSpace == null)
				{
					_worldSpace = (CBool) CR2WTypeManager.Create("Bool", "worldSpace", cr2w, this);
				}
				return _worldSpace;
			}
			set
			{
				if (_worldSpace == value)
				{
					return;
				}
				_worldSpace = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
