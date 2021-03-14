using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerSpawnBox : IParticleInitializer
	{
		private CHandle<IEvaluatorVector> _extents;
		private CBool _worldSpace;
		private CBool _surfaceOnly;

		[Ordinal(4)] 
		[RED("extents")] 
		public CHandle<IEvaluatorVector> Extents
		{
			get
			{
				if (_extents == null)
				{
					_extents = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "extents", cr2w, this);
				}
				return _extents;
			}
			set
			{
				if (_extents == value)
				{
					return;
				}
				_extents = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		public CParticleInitializerSpawnBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
