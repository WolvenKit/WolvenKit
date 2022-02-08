using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialWheelUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Slot")] 
		public CHandle<RadialSlot> Slot
		{
			get => GetPropertyValue<CHandle<RadialSlot>>();
			set => SetPropertyValue<CHandle<RadialSlot>>(value);
		}
	}
}
