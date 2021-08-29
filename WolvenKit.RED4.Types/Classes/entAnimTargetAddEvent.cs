using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimTargetAddEvent : redEvent
	{
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private CName _bodyPart;

		[Ordinal(0)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get => GetProperty(ref _targetPositionProvider);
			set => SetProperty(ref _targetPositionProvider, value);
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}
	}
}
