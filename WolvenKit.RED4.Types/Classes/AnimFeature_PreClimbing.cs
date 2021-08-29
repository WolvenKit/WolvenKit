using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PreClimbing : animAnimFeature
	{
		private Vector4 _edgePositionLS;
		private CFloat _valid;

		[Ordinal(0)] 
		[RED("edgePositionLS")] 
		public Vector4 EdgePositionLS
		{
			get => GetProperty(ref _edgePositionLS);
			set => SetProperty(ref _edgePositionLS, value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CFloat Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}
	}
}
