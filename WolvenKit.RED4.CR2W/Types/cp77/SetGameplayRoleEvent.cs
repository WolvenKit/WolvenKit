using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGameplayRoleEvent : redEvent
	{
		private CEnum<EGameplayRole> _gameplayRole;

		[Ordinal(0)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetProperty(ref _gameplayRole);
			set => SetProperty(ref _gameplayRole, value);
		}

		public SetGameplayRoleEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
