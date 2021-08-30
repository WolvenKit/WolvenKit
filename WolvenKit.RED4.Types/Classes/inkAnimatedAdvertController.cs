using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkAnimatedAdvertController : inkWidgetLogicController
	{
		private CName _animName;
		private CEnum<inkanimLoopType> _loopType;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		public inkAnimatedAdvertController()
		{
			_loopType = new() { Value = Enums.inkanimLoopType.Cycle };
		}
	}
}
