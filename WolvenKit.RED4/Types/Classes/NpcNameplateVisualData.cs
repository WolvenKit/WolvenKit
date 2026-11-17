using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NpcNameplateVisualData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("npcNextToCrosshair")] 
		public gameuiNPCNextToTheCrosshair NpcNextToCrosshair
		{
			get => GetPropertyValue<gameuiNPCNextToTheCrosshair>();
			set => SetPropertyValue<gameuiNPCNextToTheCrosshair>(value);
		}

		public NpcNameplateVisualData()
		{
			NpcNextToCrosshair = new gameuiNPCNextToTheCrosshair();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
