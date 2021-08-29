using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		private CBool _startCombat;

		[Ordinal(0)] 
		[RED("startCombat")] 
		public CBool StartCombat
		{
			get => GetProperty(ref _startCombat);
			set => SetProperty(ref _startCombat, value);
		}
	}
}
