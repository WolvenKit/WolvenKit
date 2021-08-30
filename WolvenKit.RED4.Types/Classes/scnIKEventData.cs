using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnIKEventData : RedBaseClass
	{
		private Quaternion _orientation;
		private scnAnimTargetBasicData _basic;
		private CName _chainName;
		private animIKTargetRequest _request;

		[Ordinal(0)] 
		[RED("orientation")] 
		public Quaternion Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		[Ordinal(1)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetProperty(ref _basic);
			set => SetProperty(ref _basic, value);
		}

		[Ordinal(2)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get => GetProperty(ref _chainName);
			set => SetProperty(ref _chainName, value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		public scnIKEventData()
		{
			_chainName = "ikRightArm";
		}
	}
}
