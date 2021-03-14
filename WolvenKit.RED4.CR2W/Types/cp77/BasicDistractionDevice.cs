using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDevice : InteractiveDevice
	{
		private CHandle<AnimFeature_DistractionState> _animFeatureDataDistractor;
		private CName _animFeatureDataNameDistractor;
		private CArray<CName> _distractionComponentSwapNamesToON;
		private CArray<CName> _distractionComponentSwapNamesToOFF;
		private CArray<CHandle<entIPlacedComponent>> _distractionComponentON;
		private CArray<CHandle<entIPlacedComponent>> _cdistractionComponentOFF;

		[Ordinal(93)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get
			{
				if (_animFeatureDataDistractor == null)
				{
					_animFeatureDataDistractor = (CHandle<AnimFeature_DistractionState>) CR2WTypeManager.Create("handle:AnimFeature_DistractionState", "animFeatureDataDistractor", cr2w, this);
				}
				return _animFeatureDataDistractor;
			}
			set
			{
				if (_animFeatureDataDistractor == value)
				{
					return;
				}
				_animFeatureDataDistractor = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get
			{
				if (_animFeatureDataNameDistractor == null)
				{
					_animFeatureDataNameDistractor = (CName) CR2WTypeManager.Create("CName", "animFeatureDataNameDistractor", cr2w, this);
				}
				return _animFeatureDataNameDistractor;
			}
			set
			{
				if (_animFeatureDataNameDistractor == value)
				{
					return;
				}
				_animFeatureDataNameDistractor = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get
			{
				if (_distractionComponentSwapNamesToON == null)
				{
					_distractionComponentSwapNamesToON = (CArray<CName>) CR2WTypeManager.Create("array:CName", "distractionComponentSwapNamesToON", cr2w, this);
				}
				return _distractionComponentSwapNamesToON;
			}
			set
			{
				if (_distractionComponentSwapNamesToON == value)
				{
					return;
				}
				_distractionComponentSwapNamesToON = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get
			{
				if (_distractionComponentSwapNamesToOFF == null)
				{
					_distractionComponentSwapNamesToOFF = (CArray<CName>) CR2WTypeManager.Create("array:CName", "distractionComponentSwapNamesToOFF", cr2w, this);
				}
				return _distractionComponentSwapNamesToOFF;
			}
			set
			{
				if (_distractionComponentSwapNamesToOFF == value)
				{
					return;
				}
				_distractionComponentSwapNamesToOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get
			{
				if (_distractionComponentON == null)
				{
					_distractionComponentON = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "distractionComponentON", cr2w, this);
				}
				return _distractionComponentON;
			}
			set
			{
				if (_distractionComponentON == value)
				{
					return;
				}
				_distractionComponentON = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("cdistractionComponentOFF")] 
		public CArray<CHandle<entIPlacedComponent>> CdistractionComponentOFF
		{
			get
			{
				if (_cdistractionComponentOFF == null)
				{
					_cdistractionComponentOFF = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "cdistractionComponentOFF", cr2w, this);
				}
				return _cdistractionComponentOFF;
			}
			set
			{
				if (_cdistractionComponentOFF == value)
				{
					return;
				}
				_cdistractionComponentOFF = value;
				PropertySet(this);
			}
		}

		public BasicDistractionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
