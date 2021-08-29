using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NpcNameplateVisualData : RedBaseClass
	{
		private gameuiNPCNextToTheCrosshair _npcNextToCrosshair;
		private CArray<gameuiBuffInfo> _buffList;
		private CArray<gameuiBuffInfo> _debuffList;

		[Ordinal(0)] 
		[RED("npcNextToCrosshair")] 
		public gameuiNPCNextToTheCrosshair NpcNextToCrosshair
		{
			get => GetProperty(ref _npcNextToCrosshair);
			set => SetProperty(ref _npcNextToCrosshair, value);
		}

		[Ordinal(1)] 
		[RED("buffList")] 
		public CArray<gameuiBuffInfo> BuffList
		{
			get => GetProperty(ref _buffList);
			set => SetProperty(ref _buffList, value);
		}

		[Ordinal(2)] 
		[RED("debuffList")] 
		public CArray<gameuiBuffInfo> DebuffList
		{
			get => GetProperty(ref _debuffList);
			set => SetProperty(ref _debuffList, value);
		}
	}
}
