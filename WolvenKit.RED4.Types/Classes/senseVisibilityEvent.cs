using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibilityEvent : redEvent
	{
		private CWeakHandle<gameObject> _target;
		private CBool _isVisible;
		private CName _description;
		private TweakDBID _shapeId;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get => GetProperty(ref _shapeId);
			set => SetProperty(ref _shapeId, value);
		}
	}
}
