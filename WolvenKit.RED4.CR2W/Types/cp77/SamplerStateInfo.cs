using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SamplerStateInfo : CVariable
	{
		private CEnum<ETextureFilteringMin> _filteringMin;
		private CEnum<ETextureFilteringMag> _filteringMag;
		private CEnum<ETextureFilteringMip> _filteringMip;
		private CEnum<ETextureAddressing> _addressU;
		private CEnum<ETextureAddressing> _addressV;
		private CEnum<ETextureAddressing> _addressW;
		private CEnum<ETextureComparisonFunction> _comparisonFunc;
		private CUInt8 _register;

		[Ordinal(0)] 
		[RED("filteringMin")] 
		public CEnum<ETextureFilteringMin> FilteringMin
		{
			get
			{
				if (_filteringMin == null)
				{
					_filteringMin = (CEnum<ETextureFilteringMin>) CR2WTypeManager.Create("ETextureFilteringMin", "filteringMin", cr2w, this);
				}
				return _filteringMin;
			}
			set
			{
				if (_filteringMin == value)
				{
					return;
				}
				_filteringMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("filteringMag")] 
		public CEnum<ETextureFilteringMag> FilteringMag
		{
			get
			{
				if (_filteringMag == null)
				{
					_filteringMag = (CEnum<ETextureFilteringMag>) CR2WTypeManager.Create("ETextureFilteringMag", "filteringMag", cr2w, this);
				}
				return _filteringMag;
			}
			set
			{
				if (_filteringMag == value)
				{
					return;
				}
				_filteringMag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("filteringMip")] 
		public CEnum<ETextureFilteringMip> FilteringMip
		{
			get
			{
				if (_filteringMip == null)
				{
					_filteringMip = (CEnum<ETextureFilteringMip>) CR2WTypeManager.Create("ETextureFilteringMip", "filteringMip", cr2w, this);
				}
				return _filteringMip;
			}
			set
			{
				if (_filteringMip == value)
				{
					return;
				}
				_filteringMip = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("addressU")] 
		public CEnum<ETextureAddressing> AddressU
		{
			get
			{
				if (_addressU == null)
				{
					_addressU = (CEnum<ETextureAddressing>) CR2WTypeManager.Create("ETextureAddressing", "addressU", cr2w, this);
				}
				return _addressU;
			}
			set
			{
				if (_addressU == value)
				{
					return;
				}
				_addressU = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("addressV")] 
		public CEnum<ETextureAddressing> AddressV
		{
			get
			{
				if (_addressV == null)
				{
					_addressV = (CEnum<ETextureAddressing>) CR2WTypeManager.Create("ETextureAddressing", "addressV", cr2w, this);
				}
				return _addressV;
			}
			set
			{
				if (_addressV == value)
				{
					return;
				}
				_addressV = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("addressW")] 
		public CEnum<ETextureAddressing> AddressW
		{
			get
			{
				if (_addressW == null)
				{
					_addressW = (CEnum<ETextureAddressing>) CR2WTypeManager.Create("ETextureAddressing", "addressW", cr2w, this);
				}
				return _addressW;
			}
			set
			{
				if (_addressW == value)
				{
					return;
				}
				_addressW = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("comparisonFunc")] 
		public CEnum<ETextureComparisonFunction> ComparisonFunc
		{
			get
			{
				if (_comparisonFunc == null)
				{
					_comparisonFunc = (CEnum<ETextureComparisonFunction>) CR2WTypeManager.Create("ETextureComparisonFunction", "comparisonFunc", cr2w, this);
				}
				return _comparisonFunc;
			}
			set
			{
				if (_comparisonFunc == value)
				{
					return;
				}
				_comparisonFunc = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("register")] 
		public CUInt8 Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CUInt8) CR2WTypeManager.Create("Uint8", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		public SamplerStateInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
