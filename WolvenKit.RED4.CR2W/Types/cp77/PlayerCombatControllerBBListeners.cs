using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerBBListeners : CVariable
	{
		private CHandle<redCallbackObject> _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CHandle<redCallbackObject> CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}

		public PlayerCombatControllerBBListeners(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
