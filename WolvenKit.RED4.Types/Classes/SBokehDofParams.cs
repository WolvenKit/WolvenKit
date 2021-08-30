using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBokehDofParams : RedBaseClass
	{
		private CBool _enabled;
		private CFloat _hexToCircleScale;
		private CBool _usePhysicalSetup;
		private CFloat _planeInFocus;
		private CEnum<EApertureValue> _fStops;
		private CFloat _bokehSizeMuliplier;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("hexToCircleScale")] 
		public CFloat HexToCircleScale
		{
			get => GetProperty(ref _hexToCircleScale);
			set => SetProperty(ref _hexToCircleScale, value);
		}

		[Ordinal(2)] 
		[RED("usePhysicalSetup")] 
		public CBool UsePhysicalSetup
		{
			get => GetProperty(ref _usePhysicalSetup);
			set => SetProperty(ref _usePhysicalSetup, value);
		}

		[Ordinal(3)] 
		[RED("planeInFocus")] 
		public CFloat PlaneInFocus
		{
			get => GetProperty(ref _planeInFocus);
			set => SetProperty(ref _planeInFocus, value);
		}

		[Ordinal(4)] 
		[RED("fStops")] 
		public CEnum<EApertureValue> FStops
		{
			get => GetProperty(ref _fStops);
			set => SetProperty(ref _fStops, value);
		}

		[Ordinal(5)] 
		[RED("bokehSizeMuliplier")] 
		public CFloat BokehSizeMuliplier
		{
			get => GetProperty(ref _bokehSizeMuliplier);
			set => SetProperty(ref _bokehSizeMuliplier, value);
		}

		public SBokehDofParams()
		{
			_hexToCircleScale = 1.000000F;
			_planeInFocus = 3.000000F;
			_fStops = new() { Value = Enums.EApertureValue.f_4_0 };
			_bokehSizeMuliplier = 1.000000F;
		}
	}
}
