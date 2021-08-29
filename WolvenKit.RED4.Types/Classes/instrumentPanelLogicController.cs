using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class instrumentPanelLogicController : IVehicleModuleController
	{
		private inkImageWidgetReference _lightStateImageWidget;
		private inkImageWidgetReference _cautionStateImageWidget;
		private CHandle<redCallbackObject> _lightStateBBConnectionId;
		private CHandle<redCallbackObject> _cautionStateBBConnectionId;
		private CWeakHandle<gameIBlackboard> _vehBB;

		[Ordinal(1)] 
		[RED("lightStateImageWidget")] 
		public inkImageWidgetReference LightStateImageWidget
		{
			get => GetProperty(ref _lightStateImageWidget);
			set => SetProperty(ref _lightStateImageWidget, value);
		}

		[Ordinal(2)] 
		[RED("cautionStateImageWidget")] 
		public inkImageWidgetReference CautionStateImageWidget
		{
			get => GetProperty(ref _cautionStateImageWidget);
			set => SetProperty(ref _cautionStateImageWidget, value);
		}

		[Ordinal(3)] 
		[RED("lightStateBBConnectionId")] 
		public CHandle<redCallbackObject> LightStateBBConnectionId
		{
			get => GetProperty(ref _lightStateBBConnectionId);
			set => SetProperty(ref _lightStateBBConnectionId, value);
		}

		[Ordinal(4)] 
		[RED("cautionStateBBConnectionId")] 
		public CHandle<redCallbackObject> CautionStateBBConnectionId
		{
			get => GetProperty(ref _cautionStateBBConnectionId);
			set => SetProperty(ref _cautionStateBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}
	}
}
