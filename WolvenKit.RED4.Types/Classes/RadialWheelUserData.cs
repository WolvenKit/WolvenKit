using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialWheelUserData : IScriptable
	{
		private CHandle<RadialSlot> _slot;

		[Ordinal(0)] 
		[RED("Slot")] 
		public CHandle<RadialSlot> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}
	}
}
