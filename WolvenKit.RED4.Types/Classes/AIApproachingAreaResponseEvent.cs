using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIApproachingAreaResponseEvent : redEvent
	{
		private CWeakHandle<entEntity> _sender;
		private CWeakHandle<gameStaticAreaShapeComponent> _areaComponent;
		private CBool _isPassingThrough;

		[Ordinal(0)] 
		[RED("sender")] 
		public CWeakHandle<entEntity> Sender
		{
			get => GetProperty(ref _sender);
			set => SetProperty(ref _sender, value);
		}

		[Ordinal(1)] 
		[RED("areaComponent")] 
		public CWeakHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(2)] 
		[RED("isPassingThrough")] 
		public CBool IsPassingThrough
		{
			get => GetProperty(ref _isPassingThrough);
			set => SetProperty(ref _isPassingThrough, value);
		}
	}
}
