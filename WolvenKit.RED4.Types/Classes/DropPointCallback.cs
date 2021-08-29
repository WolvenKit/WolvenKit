using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<DropPointSystem> _dps;

		[Ordinal(1)] 
		[RED("dps")] 
		public CWeakHandle<DropPointSystem> Dps
		{
			get => GetProperty(ref _dps);
			set => SetProperty(ref _dps, value);
		}
	}
}
