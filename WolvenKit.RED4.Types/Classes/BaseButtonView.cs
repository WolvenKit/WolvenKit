using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseButtonView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}
	}
}
