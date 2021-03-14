using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _innerRadius;
		private CHandle<IEvaluatorFloat> _outerRadius;
		private CBool _surfaceOnly;
		private CBool _worldSpace;
		private CMatrix _spawnToLocal;

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

		[Ordinal(8)] 
		[RED("spawnToLocal")] 
		public CMatrix SpawnToLocal
		{
			get
			{
				if (_spawnToLocal == null)
				{
					_spawnToLocal = (CMatrix) CR2WTypeManager.Create("Matrix", "spawnToLocal", cr2w, this);
				}
				return _spawnToLocal;
			}
			set
			{
				if (_spawnToLocal == value)
				{
					return;
				}
				_spawnToLocal = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
