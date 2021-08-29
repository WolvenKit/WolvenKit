using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayRoleChangeNotification : redEvent
	{
		private CEnum<EGameplayRole> _newRole;
		private CEnum<EGameplayRole> _oldRole;

		[Ordinal(0)] 
		[RED("newRole")] 
		public CEnum<EGameplayRole> NewRole
		{
			get => GetProperty(ref _newRole);
			set => SetProperty(ref _newRole, value);
		}

		[Ordinal(1)] 
		[RED("oldRole")] 
		public CEnum<EGameplayRole> OldRole
		{
			get => GetProperty(ref _oldRole);
			set => SetProperty(ref _oldRole, value);
		}
	}
}
