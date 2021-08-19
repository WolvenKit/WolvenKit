using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerDelayCallbacksIds : CVariable
	{
		private gameDelayID _crouch;

		[Ordinal(0)] 
		[RED("crouch")] 
		public gameDelayID Crouch
		{
			get => GetProperty(ref _crouch);
			set => SetProperty(ref _crouch, value);
		}

		public PlayerCombatControllerDelayCallbacksIds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
