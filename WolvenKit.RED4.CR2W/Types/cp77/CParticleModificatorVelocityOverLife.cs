using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _velocity;
		private CFloat _scale;
		private CBool _modulate;
		private CBool _absolute;

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

		[Ordinal(7)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get
			{
				if (_absolute == null)
				{
					_absolute = (CBool) CR2WTypeManager.Create("Bool", "absolute", cr2w, this);
				}
				return _absolute;
			}
			set
			{
				if (_absolute == value)
				{
					return;
				}
				_absolute = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorVelocityOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
