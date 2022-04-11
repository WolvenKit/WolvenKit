using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IronsightTargetHealthChangeListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("parentIronsight")] 
		public CWeakHandle<IronsightGameController> ParentIronsight
		{
			get => GetPropertyValue<CWeakHandle<IronsightGameController>>();
			set => SetPropertyValue<CWeakHandle<IronsightGameController>>(value);
		}
	}
}
