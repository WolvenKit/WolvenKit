using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpConveyorObject : gameObject
	{
		private CFloat _rotationLerpFactor;
		private CBool _ignoreZAxis;

		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get => GetProperty(ref _rotationLerpFactor);
			set => SetProperty(ref _rotationLerpFactor, value);
		}

		[Ordinal(41)] 
		[RED("ignoreZAxis")] 
		public CBool IgnoreZAxis
		{
			get => GetProperty(ref _ignoreZAxis);
			set => SetProperty(ref _ignoreZAxis, value);
		}
	}
}
