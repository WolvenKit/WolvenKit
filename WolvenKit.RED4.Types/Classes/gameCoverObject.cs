using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCoverObject : gameObject
	{
		private CEnum<animCoverState> _coverType;
		private CFloat _slotRadius;
		private CFloat _hpMax;
		private CBool _isDestructible;
		private CFloat _fovDegrees;
		private CFloat _fovExposureDegrees;

		[Ordinal(40)] 
		[RED("coverType")] 
		public CEnum<animCoverState> CoverType
		{
			get => GetProperty(ref _coverType);
			set => SetProperty(ref _coverType, value);
		}

		[Ordinal(41)] 
		[RED("slotRadius")] 
		public CFloat SlotRadius
		{
			get => GetProperty(ref _slotRadius);
			set => SetProperty(ref _slotRadius, value);
		}

		[Ordinal(42)] 
		[RED("hpMax")] 
		public CFloat HpMax
		{
			get => GetProperty(ref _hpMax);
			set => SetProperty(ref _hpMax, value);
		}

		[Ordinal(43)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetProperty(ref _isDestructible);
			set => SetProperty(ref _isDestructible, value);
		}

		[Ordinal(44)] 
		[RED("fovDegrees")] 
		public CFloat FovDegrees
		{
			get => GetProperty(ref _fovDegrees);
			set => SetProperty(ref _fovDegrees, value);
		}

		[Ordinal(45)] 
		[RED("fovExposureDegrees")] 
		public CFloat FovExposureDegrees
		{
			get => GetProperty(ref _fovExposureDegrees);
			set => SetProperty(ref _fovExposureDegrees, value);
		}

		public gameCoverObject()
		{
			_coverType = new() { Value = Enums.animCoverState.LowCover };
			_slotRadius = 0.800000F;
			_hpMax = 1000.000000F;
			_isDestructible = true;
			_fovDegrees = 120.000000F;
			_fovExposureDegrees = 160.000000F;
		}
	}
}
