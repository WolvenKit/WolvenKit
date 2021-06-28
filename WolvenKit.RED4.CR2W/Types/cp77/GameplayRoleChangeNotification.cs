using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleChangeNotification : redEvent
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

		public GameplayRoleChangeNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
