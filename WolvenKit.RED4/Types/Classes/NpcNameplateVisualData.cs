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

		[Ordinal(1)] 
		[RED("buffList")] 
		public CArray<gameuiBuffInfo> BuffList
		{
			get => GetPropertyValue<CArray<gameuiBuffInfo>>();
			set => SetPropertyValue<CArray<gameuiBuffInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("debuffList")] 
		public CArray<gameuiBuffInfo> DebuffList
		{
			get => GetPropertyValue<CArray<gameuiBuffInfo>>();
			set => SetPropertyValue<CArray<gameuiBuffInfo>>(value);
		}

		public NpcNameplateVisualData()
		{
			NpcNextToCrosshair = new gameuiNPCNextToTheCrosshair { Attitude = Enums.EAIAttitude.AIA_Neutral, HighLevelState = Enums.gamedataNPCHighLevelState.Any };
			BuffList = new();
			DebuffList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
