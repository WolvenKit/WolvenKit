using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		private CBool _testMountRequest;
		private CBool _testUnmountRequest;
		private CBool _acceptInstant;
		private CBool _acceptNotInstant;

		[Ordinal(1)] 
		[RED("testMountRequest")] 
		public CBool TestMountRequest
		{
			get => GetProperty(ref _testMountRequest);
			set => SetProperty(ref _testMountRequest, value);
		}

		[Ordinal(2)] 
		[RED("testUnmountRequest")] 
		public CBool TestUnmountRequest
		{
			get => GetProperty(ref _testUnmountRequest);
			set => SetProperty(ref _testUnmountRequest, value);
		}

		[Ordinal(3)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get => GetProperty(ref _acceptInstant);
			set => SetProperty(ref _acceptInstant, value);
		}

		[Ordinal(4)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get => GetProperty(ref _acceptNotInstant);
			set => SetProperty(ref _acceptNotInstant, value);
		}
	}
}
