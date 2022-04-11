using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionSelectSlot : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CInt32 TargetSlot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
