using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseOnBeingDetectedEvent : redEvent
	{
		private CWeakHandle<senseSensorObject> _source;
		private CBool _isVisible;
		private TweakDBID _shapeId;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<senseSensorObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(2)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get => GetProperty(ref _shapeId);
			set => SetProperty(ref _shapeId, value);
		}
	}
}
