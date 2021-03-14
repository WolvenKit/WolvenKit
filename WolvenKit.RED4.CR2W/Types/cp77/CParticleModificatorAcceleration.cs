using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAcceleration : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _direction;
		private CHandle<IEvaluatorFloat> _scale;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("direction")] 
		public CHandle<IEvaluatorVector> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		public CParticleModificatorAcceleration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
