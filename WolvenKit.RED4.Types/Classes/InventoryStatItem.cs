using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatItem : inkWidgetLogicController
	{
		private CWeakHandle<inkTextWidget> _label;
		private CWeakHandle<inkTextWidget> _value;

		[Ordinal(1)] 
		[RED("label")] 
		public CWeakHandle<inkTextWidget> Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CWeakHandle<inkTextWidget> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
