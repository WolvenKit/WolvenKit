using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEditorForceAutoHideDistance : ISerializable
	{
		private CFloat _minAutoHideDistance;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("minAutoHideDistance")] 
		public CFloat MinAutoHideDistance
		{
			get => GetProperty(ref _minAutoHideDistance);
			set => SetProperty(ref _minAutoHideDistance, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public worldEditorForceAutoHideDistance()
		{
			_minAutoHideDistance = 1.000000F;
			_multiplier = 1.000000F;
		}
	}
}
