
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWorldMapSettings_Record
	{
		[RED("cameraModeTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat CameraModeTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cursorBoundaryMax")]
		[REDProperty(IsIgnored = true)]
		public Vector2 CursorBoundaryMax
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("cursorBoundaryMin")]
		[REDProperty(IsIgnored = true)]
		public Vector2 CursorBoundaryMin
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("enableGroupTransitionAnimations")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableGroupTransitionAnimations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("freeCamera")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FreeCamera
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("mouseZoomTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MouseZoomTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("NCPDEventsVisibilityRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat NCPDEventsVisibilityRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("topDownCamera")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TopDownCamera
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("zoomLevels")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ZoomLevels
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("zoomToEnabledAtMinimumZoom")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZoomToEnabledAtMinimumZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("zoomToZoomValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZoomToZoomValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("zoomTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZoomTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
