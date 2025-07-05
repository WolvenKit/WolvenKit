using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartMetroMapController : CustomAnimationsHudGameController
	{
		[Ordinal(19)] 
		[RED("playerMarkerPane")] 
		public inkWidgetReference PlayerMarkerPane
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("playerCurrentPositionReferences")] 
		public CArray<metroMapPlayerPositionReferences> PlayerCurrentPositionReferences
		{
			get => GetPropertyValue<CArray<metroMapPlayerPositionReferences>>();
			set => SetPropertyValue<CArray<metroMapPlayerPositionReferences>>(value);
		}

		[Ordinal(21)] 
		[RED("questsSystem")] 
		public CHandle<questQuestsSystem> QuestsSystem
		{
			get => GetPropertyValue<CHandle<questQuestsSystem>>();
			set => SetPropertyValue<CHandle<questQuestsSystem>>(value);
		}

		[Ordinal(22)] 
		[RED("selectedDestinationButtonListner")] 
		public CUInt32 SelectedDestinationButtonListner
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("selectionMenuShouldBeActiveListener")] 
		public CUInt32 SelectionMenuShouldBeActiveListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("previousAnimatioNumber")] 
		public CInt32 PreviousAnimatioNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("directionAnimProxy")] 
		public CHandle<inkanimProxy> DirectionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("startupAnimProxy")] 
		public CHandle<inkanimProxy> StartupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("playerPostionMarkerAnimProxy")] 
		public CHandle<inkanimProxy> PlayerPostionMarkerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("mapOpen")] 
		public CBool MapOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("LineOffOpacity")] 
		public CFloat LineOffOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("LineOnOpacity")] 
		public CFloat LineOnOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public NcartMetroMapController()
		{
			PlayerMarkerPane = new inkWidgetReference();
			PlayerCurrentPositionReferences = new();
			LineOffOpacity = 0.040000F;
			LineOnOpacity = 0.550000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
