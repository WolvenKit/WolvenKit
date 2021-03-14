using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnSphere : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _innerRadius;
		private CHandle<IEvaluatorFloat> _outerRadius;
		private CBool _surfaceOnly;
		private CBool _spawnPositiveX;
		private CBool _spawnNegativeX;
		private CBool _spawnPositiveY;
		private CBool _spawnNegativeY;
		private CBool _spawnPositiveZ;
		private CBool _spawnNegativeZ;
		private CBool _velocity;
		private CBool _worldSpace;
		private CHandle<IEvaluatorFloat> _forceScale;

		[Ordinal(4)] 
		[RED("innerRadius")] 
		public CHandle<IEvaluatorFloat> InnerRadius
		{
			get
			{
				if (_innerRadius == null)
				{
					_innerRadius = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "innerRadius", cr2w, this);
				}
				return _innerRadius;
			}
			set
			{
				if (_innerRadius == value)
				{
					return;
				}
				_innerRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outerRadius")] 
		public CHandle<IEvaluatorFloat> OuterRadius
		{
			get
			{
				if (_outerRadius == null)
				{
					_outerRadius = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "outerRadius", cr2w, this);
				}
				return _outerRadius;
			}
			set
			{
				if (_outerRadius == value)
				{
					return;
				}
				_outerRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("surfaceOnly")] 
		public CBool SurfaceOnly
		{
			get
			{
				if (_surfaceOnly == null)
				{
					_surfaceOnly = (CBool) CR2WTypeManager.Create("Bool", "surfaceOnly", cr2w, this);
				}
				return _surfaceOnly;
			}
			set
			{
				if (_surfaceOnly == value)
				{
					return;
				}
				_surfaceOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("spawnPositiveX")] 
		public CBool SpawnPositiveX
		{
			get
			{
				if (_spawnPositiveX == null)
				{
					_spawnPositiveX = (CBool) CR2WTypeManager.Create("Bool", "spawnPositiveX", cr2w, this);
				}
				return _spawnPositiveX;
			}
			set
			{
				if (_spawnPositiveX == value)
				{
					return;
				}
				_spawnPositiveX = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spawnNegativeX")] 
		public CBool SpawnNegativeX
		{
			get
			{
				if (_spawnNegativeX == null)
				{
					_spawnNegativeX = (CBool) CR2WTypeManager.Create("Bool", "spawnNegativeX", cr2w, this);
				}
				return _spawnNegativeX;
			}
			set
			{
				if (_spawnNegativeX == value)
				{
					return;
				}
				_spawnNegativeX = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("spawnPositiveY")] 
		public CBool SpawnPositiveY
		{
			get
			{
				if (_spawnPositiveY == null)
				{
					_spawnPositiveY = (CBool) CR2WTypeManager.Create("Bool", "spawnPositiveY", cr2w, this);
				}
				return _spawnPositiveY;
			}
			set
			{
				if (_spawnPositiveY == value)
				{
					return;
				}
				_spawnPositiveY = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("spawnNegativeY")] 
		public CBool SpawnNegativeY
		{
			get
			{
				if (_spawnNegativeY == null)
				{
					_spawnNegativeY = (CBool) CR2WTypeManager.Create("Bool", "spawnNegativeY", cr2w, this);
				}
				return _spawnNegativeY;
			}
			set
			{
				if (_spawnNegativeY == value)
				{
					return;
				}
				_spawnNegativeY = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("spawnPositiveZ")] 
		public CBool SpawnPositiveZ
		{
			get
			{
				if (_spawnPositiveZ == null)
				{
					_spawnPositiveZ = (CBool) CR2WTypeManager.Create("Bool", "spawnPositiveZ", cr2w, this);
				}
				return _spawnPositiveZ;
			}
			set
			{
				if (_spawnPositiveZ == value)
				{
					return;
				}
				_spawnPositiveZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("spawnNegativeZ")] 
		public CBool SpawnNegativeZ
		{
			get
			{
				if (_spawnNegativeZ == null)
				{
					_spawnNegativeZ = (CBool) CR2WTypeManager.Create("Bool", "spawnNegativeZ", cr2w, this);
				}
				return _spawnNegativeZ;
			}
			set
			{
				if (_spawnNegativeZ == value)
				{
					return;
				}
				_spawnNegativeZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("velocity")] 
		public CBool Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (CBool) CR2WTypeManager.Create("Bool", "velocity", cr2w, this);
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get
			{
				if (_forceScale == null)
				{
					_forceScale = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "forceScale", cr2w, this);
				}
				return _forceScale;
			}
			set
			{
				if (_forceScale == value)
				{
					return;
				}
				_forceScale = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
