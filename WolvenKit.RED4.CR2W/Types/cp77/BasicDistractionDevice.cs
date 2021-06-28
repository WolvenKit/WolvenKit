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

		[Ordinal(96)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get => GetProperty(ref _animFeatureDataDistractor);
			set => SetProperty(ref _animFeatureDataDistractor, value);
		}

		[Ordinal(97)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get => GetProperty(ref _animFeatureDataNameDistractor);
			set => SetProperty(ref _animFeatureDataNameDistractor, value);
		}

		[Ordinal(98)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get => GetProperty(ref _distractionComponentSwapNamesToON);
			set => SetProperty(ref _distractionComponentSwapNamesToON, value);
		}

		[Ordinal(99)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get => GetProperty(ref _distractionComponentSwapNamesToOFF);
			set => SetProperty(ref _distractionComponentSwapNamesToOFF, value);
		}

		[Ordinal(100)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get => GetProperty(ref _distractionComponentON);
			set => SetProperty(ref _distractionComponentON, value);
		}

		[Ordinal(101)] 
		[RED("cdistractionComponentOFF")] 
		public CArray<CHandle<entIPlacedComponent>> CdistractionComponentOFF
		{
			get => GetProperty(ref _cdistractionComponentOFF);
			set => SetProperty(ref _cdistractionComponentOFF, value);
		}

		public BasicDistractionDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
