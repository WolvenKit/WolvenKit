using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudCorpoController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("ScrollText")] 
		public inkTextWidgetReference ScrollText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ScrollTextWidget")] 
		public inkWidgetReference ScrollTextWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("root_canvas")] 
		public inkWidgetReference Root_canvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("questsSystem")] 
		public CWeakHandle<questQuestsSystem> QuestsSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(16)] 
		[RED("fact3ListenerId")] 
		public CUInt32 Fact3ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("fact4ListenerId")] 
		public CUInt32 Fact4ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("fact5ListenerId")] 
		public CUInt32 Fact5ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public hudCorpoController()
		{
			ScrollText = new();
			ScrollTextWidget = new();
			Root_canvas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
