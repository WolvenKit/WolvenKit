using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animIKChainSettings : RedBaseClass
	{
		private CName _chainName;
		private CName _enableFloatTrack;
		private Vector3 _ikEndPointOffset;
		private Quaternion _ikEndRotationOffset;

		[Ordinal(0)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get => GetProperty(ref _chainName);
			set => SetProperty(ref _chainName, value);
		}

		[Ordinal(1)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get => GetProperty(ref _enableFloatTrack);
			set => SetProperty(ref _enableFloatTrack, value);
		}

		[Ordinal(2)] 
		[RED("ikEndPointOffset")] 
		public Vector3 IkEndPointOffset
		{
			get => GetProperty(ref _ikEndPointOffset);
			set => SetProperty(ref _ikEndPointOffset, value);
		}

		[Ordinal(3)] 
		[RED("ikEndRotationOffset")] 
		public Quaternion IkEndRotationOffset
		{
			get => GetProperty(ref _ikEndRotationOffset);
			set => SetProperty(ref _ikEndRotationOffset, value);
		}
	}
}
