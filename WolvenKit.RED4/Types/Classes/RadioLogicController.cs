using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("radioTextWidget")] 
		public inkTextWidgetReference RadioTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("radioEQWidget")] 
		public inkCanvasWidgetReference RadioEQWidget
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("radioStateBBConnectionId")] 
		public CHandle<redCallbackObject> RadioStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("radioNameBBConnectionId")] 
		public CHandle<redCallbackObject> RadioNameBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("eqLoopAnimProxy")] 
		public CHandle<inkanimProxy> EqLoopAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(7)] 
		[RED("radioTextWidgetSize")] 
		public Vector2 RadioTextWidgetSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public RadioLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
