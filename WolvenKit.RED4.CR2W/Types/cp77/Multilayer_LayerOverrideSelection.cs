using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerOverrideSelection : CVariable
	{
		private CName _colorScale;
		private CName _normalStrength;
		private CName _roughLevelsIn;
		private CName _roughLevelsOut;
		private CName _metalLevelsIn;
		private CName _metalLevelsOut;

		[Ordinal(0)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get
			{
				if (_colorScale == null)
				{
					_colorScale = (CName) CR2WTypeManager.Create("CName", "colorScale", cr2w, this);
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
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get
			{
				if (_normalStrength == null)
				{
					_normalStrength = (CName) CR2WTypeManager.Create("CName", "normalStrength", cr2w, this);
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

		[Ordinal(2)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get
			{
				if (_roughLevelsIn == null)
				{
					_roughLevelsIn = (CName) CR2WTypeManager.Create("CName", "roughLevelsIn", cr2w, this);
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

		[Ordinal(3)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get
			{
				if (_roughLevelsOut == null)
				{
					_roughLevelsOut = (CName) CR2WTypeManager.Create("CName", "roughLevelsOut", cr2w, this);
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

		[Ordinal(4)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get
			{
				if (_metalLevelsIn == null)
				{
					_metalLevelsIn = (CName) CR2WTypeManager.Create("CName", "metalLevelsIn", cr2w, this);
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

		[Ordinal(5)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get
			{
				if (_metalLevelsOut == null)
				{
					_metalLevelsOut = (CName) CR2WTypeManager.Create("CName", "metalLevelsOut", cr2w, this);
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

		public Multilayer_LayerOverrideSelection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
