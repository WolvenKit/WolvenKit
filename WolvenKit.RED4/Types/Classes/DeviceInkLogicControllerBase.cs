using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceInkLogicControllerBase : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkWidget> TargetWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public DeviceInkLogicControllerBase()
		{
			TargetWidgetRef = new();
			DisplayNameWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
