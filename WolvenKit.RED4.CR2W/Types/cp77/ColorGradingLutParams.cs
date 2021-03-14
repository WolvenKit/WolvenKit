using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorGradingLutParams : CVariable
	{
		private rRef<CBitmapTexture> _lUT;
		private CEnum<EColorMappingFunction> _inputMapping;
		private CEnum<EColorMappingFunction> _outputMapping;

		[Ordinal(0)] 
		[RED("LUT")] 
		public rRef<CBitmapTexture> LUT
		{
			get
			{
				if (_lUT == null)
				{
					_lUT = (rRef<CBitmapTexture>) CR2WTypeManager.Create("rRef:CBitmapTexture", "LUT", cr2w, this);
				}
				return _lUT;
			}
			set
			{
				if (_lUT == value)
				{
					return;
				}
				_lUT = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputMapping")] 
		public CEnum<EColorMappingFunction> InputMapping
		{
			get
			{
				if (_inputMapping == null)
				{
					_inputMapping = (CEnum<EColorMappingFunction>) CR2WTypeManager.Create("EColorMappingFunction", "inputMapping", cr2w, this);
				}
				return _inputMapping;
			}
			set
			{
				if (_inputMapping == value)
				{
					return;
				}
				_inputMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outputMapping")] 
		public CEnum<EColorMappingFunction> OutputMapping
		{
			get
			{
				if (_outputMapping == null)
				{
					_outputMapping = (CEnum<EColorMappingFunction>) CR2WTypeManager.Create("EColorMappingFunction", "outputMapping", cr2w, this);
				}
				return _outputMapping;
			}
			set
			{
				if (_outputMapping == value)
				{
					return;
				}
				_outputMapping = value;
				PropertySet(this);
			}
		}

		public ColorGradingLutParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
