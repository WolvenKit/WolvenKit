using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("dps")] 
		public CWeakHandle<DropPointSystem> Dps
		{
			get => GetPropertyValue<CWeakHandle<DropPointSystem>>();
			set => SetPropertyValue<CWeakHandle<DropPointSystem>>(value);
		}
	}
}
