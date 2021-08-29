using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleScreenProjectionLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkTextWidget> _widgetPos;
		private CWeakHandle<inkTextWidget> _worldPos;
		private CHandle<inkScreenProjection> _projection;

		[Ordinal(1)] 
		[RED("widgetPos")] 
		public CWeakHandle<inkTextWidget> WidgetPos
		{
			get => GetProperty(ref _widgetPos);
			set => SetProperty(ref _widgetPos, value);
		}

		[Ordinal(2)] 
		[RED("worldPos")] 
		public CWeakHandle<inkTextWidget> WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}

		[Ordinal(3)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}
	}
}
