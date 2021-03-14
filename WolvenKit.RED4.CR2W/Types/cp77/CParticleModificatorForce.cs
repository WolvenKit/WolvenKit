using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorForce : IParticleModificator
	{
		private Vector3 _pivot;
		private CFloat _radius;
		private CHandle<IEvaluatorFloat> _scale;
		private CHandle<IEvaluatorVector> _damp;

		[Ordinal(4)] 
		[RED("pivot")] 
		public Vector3 Pivot
		{
			get
			{
				if (_pivot == null)
				{
					_pivot = (Vector3) CR2WTypeManager.Create("Vector3", "pivot", cr2w, this);
				}
				return _pivot;
			}
			set
			{
				if (_pivot == value)
				{
					return;
				}
				_pivot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("damp")] 
		public CHandle<IEvaluatorVector> Damp
		{
			get
			{
				if (_damp == null)
				{
					_damp = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "damp", cr2w, this);
				}
				return _damp;
			}
			set
			{
				if (_damp == value)
				{
					return;
				}
				_damp = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorForce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
