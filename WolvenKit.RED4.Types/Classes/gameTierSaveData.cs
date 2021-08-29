using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTierSaveData : ISerializable
	{
		private CArray<gameGlobalTierSaveData> _globalTiers;

		[Ordinal(0)] 
		[RED("globalTiers")] 
		public CArray<gameGlobalTierSaveData> GlobalTiers
		{
			get => GetProperty(ref _globalTiers);
			set => SetProperty(ref _globalTiers, value);
		}
	}
}
