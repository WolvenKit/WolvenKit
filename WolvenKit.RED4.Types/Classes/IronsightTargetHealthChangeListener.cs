using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IronsightTargetHealthChangeListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<IronsightGameController> _parentIronsight;

		[Ordinal(0)] 
		[RED("parentIronsight")] 
		public CWeakHandle<IronsightGameController> ParentIronsight
		{
			get => GetProperty(ref _parentIronsight);
			set => SetProperty(ref _parentIronsight, value);
		}
	}
}
