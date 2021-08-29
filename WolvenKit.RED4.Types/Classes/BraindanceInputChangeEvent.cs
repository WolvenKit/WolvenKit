using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BraindanceInputChangeEvent : redEvent
	{
		private CHandle<BraindanceSystem> _bdSystem;

		[Ordinal(0)] 
		[RED("bdSystem")] 
		public CHandle<BraindanceSystem> BdSystem
		{
			get => GetProperty(ref _bdSystem);
			set => SetProperty(ref _bdSystem, value);
		}
	}
}
