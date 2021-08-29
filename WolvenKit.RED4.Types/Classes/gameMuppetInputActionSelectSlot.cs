using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionSelectSlot : gameIMuppetInputAction
	{
		private CInt32 _targetSlot;

		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CInt32 TargetSlot
		{
			get => GetProperty(ref _targetSlot);
			set => SetProperty(ref _targetSlot, value);
		}
	}
}
