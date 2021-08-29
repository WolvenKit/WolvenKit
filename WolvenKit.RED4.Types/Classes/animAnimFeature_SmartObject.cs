using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_SmartObject : animAnimFeature
	{
		private CInt32 _state;
		private CName _privateAnimationName;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("privateAnimationName")] 
		public CName PrivateAnimationName
		{
			get => GetProperty(ref _privateAnimationName);
			set => SetProperty(ref _privateAnimationName, value);
		}
	}
}
