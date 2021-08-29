using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RoadBlockControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isBlocking;
		private CBool _negateAnimState;
		private TweakDBID _nameForBlocking;
		private TweakDBID _nameForUnblocking;

		[Ordinal(104)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetProperty(ref _isBlocking);
			set => SetProperty(ref _isBlocking, value);
		}

		[Ordinal(105)] 
		[RED("negateAnimState")] 
		public CBool NegateAnimState
		{
			get => GetProperty(ref _negateAnimState);
			set => SetProperty(ref _negateAnimState, value);
		}

		[Ordinal(106)] 
		[RED("nameForBlocking")] 
		public TweakDBID NameForBlocking
		{
			get => GetProperty(ref _nameForBlocking);
			set => SetProperty(ref _nameForBlocking, value);
		}

		[Ordinal(107)] 
		[RED("nameForUnblocking")] 
		public TweakDBID NameForUnblocking
		{
			get => GetProperty(ref _nameForUnblocking);
			set => SetProperty(ref _nameForUnblocking, value);
		}
	}
}
