using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Setup : CResource
	{
		private CArray<Multilayer_Layer> _layers;
		private CFloat _ratio;
		private CBool _useNormal;

		[Ordinal(1)] 
		[RED("layers")] 
		public CArray<Multilayer_Layer> Layers
		{
			get
			{
				if (_layers == null)
				{
					_layers = (CArray<Multilayer_Layer>) CR2WTypeManager.Create("array:Multilayer_Layer", "layers", cr2w, this);
				}
				return _layers;
			}
			set
			{
				if (_layers == value)
				{
					return;
				}
				_layers = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get
			{
				if (_ratio == null)
				{
					_ratio = (CFloat) CR2WTypeManager.Create("Float", "ratio", cr2w, this);
				}
				return _ratio;
			}
			set
			{
				if (_ratio == value)
				{
					return;
				}
				_ratio = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useNormal")] 
		public CBool UseNormal
		{
			get
			{
				if (_useNormal == null)
				{
					_useNormal = (CBool) CR2WTypeManager.Create("Bool", "useNormal", cr2w, this);
				}
				return _useNormal;
			}
			set
			{
				if (_useNormal == value)
				{
					return;
				}
				_useNormal = value;
				PropertySet(this);
			}
		}

		public Multilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
