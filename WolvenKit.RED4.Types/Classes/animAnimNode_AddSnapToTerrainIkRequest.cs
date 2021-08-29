using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_AddSnapToTerrainIkRequest : animAnimNode_OnePoseInput
	{
		private animFloatLink _animDeltaZ;
		private animSnapToTerrainIkRequest _leftFootRequest;
		private animSnapToTerrainIkRequest _rightFootRequest;
		private animHipsIkRequest _hipsRequest;

		[Ordinal(13)] 
		[RED("animDeltaZ")] 
		public animFloatLink AnimDeltaZ
		{
			get => GetProperty(ref _animDeltaZ);
			set => SetProperty(ref _animDeltaZ, value);
		}

		[Ordinal(14)] 
		[RED("leftFootRequest")] 
		public animSnapToTerrainIkRequest LeftFootRequest
		{
			get => GetProperty(ref _leftFootRequest);
			set => SetProperty(ref _leftFootRequest, value);
		}

		[Ordinal(15)] 
		[RED("rightFootRequest")] 
		public animSnapToTerrainIkRequest RightFootRequest
		{
			get => GetProperty(ref _rightFootRequest);
			set => SetProperty(ref _rightFootRequest, value);
		}

		[Ordinal(16)] 
		[RED("hipsRequest")] 
		public animHipsIkRequest HipsRequest
		{
			get => GetProperty(ref _hipsRequest);
			set => SetProperty(ref _hipsRequest, value);
		}
	}
}
