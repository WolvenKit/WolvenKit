using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerBlackboardListenersFunctions : CVariable
	{
		private CName _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CName CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}

		public PlayerCombatControllerBlackboardListenersFunctions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
