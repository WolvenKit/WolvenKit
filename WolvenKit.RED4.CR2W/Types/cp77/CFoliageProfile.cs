using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CFoliageProfile : CResource
	{
		private CFloat _cutoffAlphaMinMip;
		private CFloat _cutoffAlphaMaxMip;
		private CFloat _billboardCutoffAlpha;
		private CFloat _aoScale;
		private CFloat _terrainBlendScale;
		private CFloat _terrainBlendBias;
		private CFloat _billboardDepthScale;
		private CFloat _billboardRoughnessBias;
		private rRef<CGradient> _colorGradient;
		private CFloat _colorGradientWeight;
		private CFloat _colorGradientDarkenWeight;
		private CFloat _preserveOriginalColor;

		[Ordinal(1)] 
		[RED("cutoffAlphaMinMip")] 
		public CFloat CutoffAlphaMinMip
		{
			get
			{
				if (_cutoffAlphaMinMip == null)
				{
					_cutoffAlphaMinMip = (CFloat) CR2WTypeManager.Create("Float", "cutoffAlphaMinMip", cr2w, this);
				}
				return _cutoffAlphaMinMip;
			}
			set
			{
				if (_cutoffAlphaMinMip == value)
				{
					return;
				}
				_cutoffAlphaMinMip = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cutoffAlphaMaxMip")] 
		public CFloat CutoffAlphaMaxMip
		{
			get
			{
				if (_cutoffAlphaMaxMip == null)
				{
					_cutoffAlphaMaxMip = (CFloat) CR2WTypeManager.Create("Float", "cutoffAlphaMaxMip", cr2w, this);
				}
				return _cutoffAlphaMaxMip;
			}
			set
			{
				if (_cutoffAlphaMaxMip == value)
				{
					return;
				}
				_cutoffAlphaMaxMip = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("billboardCutoffAlpha")] 
		public CFloat BillboardCutoffAlpha
		{
			get
			{
				if (_billboardCutoffAlpha == null)
				{
					_billboardCutoffAlpha = (CFloat) CR2WTypeManager.Create("Float", "billboardCutoffAlpha", cr2w, this);
				}
				return _billboardCutoffAlpha;
			}
			set
			{
				if (_billboardCutoffAlpha == value)
				{
					return;
				}
				_billboardCutoffAlpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("aoScale")] 
		public CFloat AoScale
		{
			get
			{
				if (_aoScale == null)
				{
					_aoScale = (CFloat) CR2WTypeManager.Create("Float", "aoScale", cr2w, this);
				}
				return _aoScale;
			}
			set
			{
				if (_aoScale == value)
				{
					return;
				}
				_aoScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("terrainBlendScale")] 
		public CFloat TerrainBlendScale
		{
			get
			{
				if (_terrainBlendScale == null)
				{
					_terrainBlendScale = (CFloat) CR2WTypeManager.Create("Float", "terrainBlendScale", cr2w, this);
				}
				return _terrainBlendScale;
			}
			set
			{
				if (_terrainBlendScale == value)
				{
					return;
				}
				_terrainBlendScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("terrainBlendBias")] 
		public CFloat TerrainBlendBias
		{
			get
			{
				if (_terrainBlendBias == null)
				{
					_terrainBlendBias = (CFloat) CR2WTypeManager.Create("Float", "terrainBlendBias", cr2w, this);
				}
				return _terrainBlendBias;
			}
			set
			{
				if (_terrainBlendBias == value)
				{
					return;
				}
				_terrainBlendBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("billboardDepthScale")] 
		public CFloat BillboardDepthScale
		{
			get
			{
				if (_billboardDepthScale == null)
				{
					_billboardDepthScale = (CFloat) CR2WTypeManager.Create("Float", "billboardDepthScale", cr2w, this);
				}
				return _billboardDepthScale;
			}
			set
			{
				if (_billboardDepthScale == value)
				{
					return;
				}
				_billboardDepthScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("billboardRoughnessBias")] 
		public CFloat BillboardRoughnessBias
		{
			get
			{
				if (_billboardRoughnessBias == null)
				{
					_billboardRoughnessBias = (CFloat) CR2WTypeManager.Create("Float", "billboardRoughnessBias", cr2w, this);
				}
				return _billboardRoughnessBias;
			}
			set
			{
				if (_billboardRoughnessBias == value)
				{
					return;
				}
				_billboardRoughnessBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("colorGradient")] 
		public rRef<CGradient> ColorGradient
		{
			get
			{
				if (_colorGradient == null)
				{
					_colorGradient = (rRef<CGradient>) CR2WTypeManager.Create("rRef:CGradient", "colorGradient", cr2w, this);
				}
				return _colorGradient;
			}
			set
			{
				if (_colorGradient == value)
				{
					return;
				}
				_colorGradient = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("colorGradientWeight")] 
		public CFloat ColorGradientWeight
		{
			get
			{
				if (_colorGradientWeight == null)
				{
					_colorGradientWeight = (CFloat) CR2WTypeManager.Create("Float", "colorGradientWeight", cr2w, this);
				}
				return _colorGradientWeight;
			}
			set
			{
				if (_colorGradientWeight == value)
				{
					return;
				}
				_colorGradientWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("colorGradientDarkenWeight")] 
		public CFloat ColorGradientDarkenWeight
		{
			get
			{
				if (_colorGradientDarkenWeight == null)
				{
					_colorGradientDarkenWeight = (CFloat) CR2WTypeManager.Create("Float", "colorGradientDarkenWeight", cr2w, this);
				}
				return _colorGradientDarkenWeight;
			}
			set
			{
				if (_colorGradientDarkenWeight == value)
				{
					return;
				}
				_colorGradientDarkenWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("preserveOriginalColor")] 
		public CFloat PreserveOriginalColor
		{
			get
			{
				if (_preserveOriginalColor == null)
				{
					_preserveOriginalColor = (CFloat) CR2WTypeManager.Create("Float", "preserveOriginalColor", cr2w, this);
				}
				return _preserveOriginalColor;
			}
			set
			{
				if (_preserveOriginalColor == value)
				{
					return;
				}
				_preserveOriginalColor = value;
				PropertySet(this);
			}
		}

		public CFoliageProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
