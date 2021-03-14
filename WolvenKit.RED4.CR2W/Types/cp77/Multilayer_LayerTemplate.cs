using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplate : CResource
	{
		private Multilayer_LayerTemplateOverrides _overrides;
		private Multilayer_LayerOverrideSelection _defaultOverrides;
		private rRef<CBitmapTexture> _colorTexture;
		private rRef<CBitmapTexture> _normalTexture;
		private rRef<CBitmapTexture> _roughnessTexture;
		private rRef<CBitmapTexture> _metalnessTexture;
		private CFloat _tilingMultiplier;
		private CArrayFixedSize<CFloat> _colorMaskLevelsIn;
		private CArrayFixedSize<CFloat> _colorMaskLevelsOut;

		[Ordinal(1)] 
		[RED("overrides")] 
		public Multilayer_LayerTemplateOverrides Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (Multilayer_LayerTemplateOverrides) CR2WTypeManager.Create("Multilayer_LayerTemplateOverrides", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultOverrides")] 
		public Multilayer_LayerOverrideSelection DefaultOverrides
		{
			get
			{
				if (_defaultOverrides == null)
				{
					_defaultOverrides = (Multilayer_LayerOverrideSelection) CR2WTypeManager.Create("Multilayer_LayerOverrideSelection", "defaultOverrides", cr2w, this);
				}
				return _defaultOverrides;
			}
			set
			{
				if (_defaultOverrides == value)
				{
					return;
				}
				_defaultOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("colorTexture")] 
		public rRef<CBitmapTexture> ColorTexture
		{
			get
			{
				if (_colorTexture == null)
				{
					_colorTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "colorTexture", cr2w, this);
				}
				return _colorTexture;
			}
			set
			{
				if (_colorTexture == value)
				{
					return;
				}
				_colorTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("normalTexture")] 
		public rRef<CBitmapTexture> NormalTexture
		{
			get
			{
				if (_normalTexture == null)
				{
					_normalTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "normalTexture", cr2w, this);
				}
				return _normalTexture;
			}
			set
			{
				if (_normalTexture == value)
				{
					return;
				}
				_normalTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("roughnessTexture")] 
		public rRef<CBitmapTexture> RoughnessTexture
		{
			get
			{
				if (_roughnessTexture == null)
				{
					_roughnessTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "roughnessTexture", cr2w, this);
				}
				return _roughnessTexture;
			}
			set
			{
				if (_roughnessTexture == value)
				{
					return;
				}
				_roughnessTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("metalnessTexture")] 
		public rRef<CBitmapTexture> MetalnessTexture
		{
			get
			{
				if (_metalnessTexture == null)
				{
					_metalnessTexture = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "metalnessTexture", cr2w, this);
				}
				return _metalnessTexture;
			}
			set
			{
				if (_metalnessTexture == value)
				{
					return;
				}
				_metalnessTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tilingMultiplier")] 
		public CFloat TilingMultiplier
		{
			get
			{
				if (_tilingMultiplier == null)
				{
					_tilingMultiplier = (CFloat) CR2WTypeManager.Create("Float", "tilingMultiplier", cr2w, this);
				}
				return _tilingMultiplier;
			}
			set
			{
				if (_tilingMultiplier == value)
				{
					return;
				}
				_tilingMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("colorMaskLevelsIn", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsIn
		{
			get
			{
				if (_colorMaskLevelsIn == null)
				{
					_colorMaskLevelsIn = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[2]Float", "colorMaskLevelsIn", cr2w, this);
				}
				return _colorMaskLevelsIn;
			}
			set
			{
				if (_colorMaskLevelsIn == value)
				{
					return;
				}
				_colorMaskLevelsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("colorMaskLevelsOut", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsOut
		{
			get
			{
				if (_colorMaskLevelsOut == null)
				{
					_colorMaskLevelsOut = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[2]Float", "colorMaskLevelsOut", cr2w, this);
				}
				return _colorMaskLevelsOut;
			}
			set
			{
				if (_colorMaskLevelsOut == value)
				{
					return;
				}
				_colorMaskLevelsOut = value;
				PropertySet(this);
			}
		}

		public Multilayer_LayerTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
