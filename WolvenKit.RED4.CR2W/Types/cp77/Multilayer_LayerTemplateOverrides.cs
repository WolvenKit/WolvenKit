using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverrides : CVariable
	{
		private CArray<Multilayer_LayerTemplateOverridesColor> _colorScale;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _roughLevelsIn;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _roughLevelsOut;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _metalLevelsIn;
		private CArray<Multilayer_LayerTemplateOverridesLevels> _metalLevelsOut;
		private CArray<Multilayer_LayerTemplateOverridesNormalStrength> _normalStrength;

		[Ordinal(0)] 
		[RED("colorScale")] 
		public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale
		{
			get
			{
				if (_colorScale == null)
				{
					_colorScale = (CArray<Multilayer_LayerTemplateOverridesColor>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesColor", "colorScale", cr2w, this);
				}
				return _colorScale;
			}
			set
			{
				if (_colorScale == value)
				{
					return;
				}
				_colorScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("roughLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn
		{
			get
			{
				if (_roughLevelsIn == null)
				{
					_roughLevelsIn = (CArray<Multilayer_LayerTemplateOverridesLevels>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesLevels", "roughLevelsIn", cr2w, this);
				}
				return _roughLevelsIn;
			}
			set
			{
				if (_roughLevelsIn == value)
				{
					return;
				}
				_roughLevelsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("roughLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsOut
		{
			get
			{
				if (_roughLevelsOut == null)
				{
					_roughLevelsOut = (CArray<Multilayer_LayerTemplateOverridesLevels>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesLevels", "roughLevelsOut", cr2w, this);
				}
				return _roughLevelsOut;
			}
			set
			{
				if (_roughLevelsOut == value)
				{
					return;
				}
				_roughLevelsOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("metalLevelsIn")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn
		{
			get
			{
				if (_metalLevelsIn == null)
				{
					_metalLevelsIn = (CArray<Multilayer_LayerTemplateOverridesLevels>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesLevels", "metalLevelsIn", cr2w, this);
				}
				return _metalLevelsIn;
			}
			set
			{
				if (_metalLevelsIn == value)
				{
					return;
				}
				_metalLevelsIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("metalLevelsOut")] 
		public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut
		{
			get
			{
				if (_metalLevelsOut == null)
				{
					_metalLevelsOut = (CArray<Multilayer_LayerTemplateOverridesLevels>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesLevels", "metalLevelsOut", cr2w, this);
				}
				return _metalLevelsOut;
			}
			set
			{
				if (_metalLevelsOut == value)
				{
					return;
				}
				_metalLevelsOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("normalStrength")] 
		public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength
		{
			get
			{
				if (_normalStrength == null)
				{
					_normalStrength = (CArray<Multilayer_LayerTemplateOverridesNormalStrength>) CR2WTypeManager.Create("array:Multilayer_LayerTemplateOverridesNormalStrength", "normalStrength", cr2w, this);
				}
				return _normalStrength;
			}
			set
			{
				if (_normalStrength == value)
				{
					return;
				}
				_normalStrength = value;
				PropertySet(this);
			}
		}

		public Multilayer_LayerTemplateOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
