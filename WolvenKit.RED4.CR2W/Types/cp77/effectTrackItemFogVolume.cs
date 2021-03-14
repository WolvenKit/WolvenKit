using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFogVolume : effectTrackItem
	{
		private CUInt8 _priority;
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CHandle<IEvaluatorFloat> _density;
		private CHandle<IEvaluatorVector> _size;
		private CHandle<IEvaluatorColor> _color;

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get
			{
				if (_densityFalloff == null)
				{
					_densityFalloff = (CFloat) CR2WTypeManager.Create("Float", "densityFalloff", cr2w, this);
				}
				return _densityFalloff;
			}
			set
			{
				if (_densityFalloff == value)
				{
					return;
				}
				_densityFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get
			{
				if (_blendFalloff == null)
				{
					_blendFalloff = (CFloat) CR2WTypeManager.Create("Float", "blendFalloff", cr2w, this);
				}
				return _blendFalloff;
			}
			set
			{
				if (_blendFalloff == value)
				{
					return;
				}
				_blendFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CHandle<IEvaluatorFloat> Density
		{
			get
			{
				if (_density == null)
				{
					_density = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("size")] 
		public CHandle<IEvaluatorVector> Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CHandle<IEvaluatorColor>) CR2WTypeManager.Create("handle:IEvaluatorColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public effectTrackItemFogVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
