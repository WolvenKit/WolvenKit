using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerActiveFlags : CVariable
	{
		private CBool _crouchActive;
		private CBool _crouchTimerPassed;
		private CBool _squadInCombat;
		private CBool _usingJhonnyReplacer;
		private CBool _usingQuickHack;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CBool CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}

		[Ordinal(1)] 
		[RED("crouchTimerPassed")] 
		public CBool CrouchTimerPassed
		{
			get => GetProperty(ref _crouchTimerPassed);
			set => SetProperty(ref _crouchTimerPassed, value);
		}

		[Ordinal(2)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetProperty(ref _squadInCombat);
			set => SetProperty(ref _squadInCombat, value);
		}

		[Ordinal(3)] 
		[RED("usingJhonnyReplacer")] 
		public CBool UsingJhonnyReplacer
		{
			get => GetProperty(ref _usingJhonnyReplacer);
			set => SetProperty(ref _usingJhonnyReplacer, value);
		}

		[Ordinal(4)] 
		[RED("usingQuickHack")] 
		public CBool UsingQuickHack
		{
			get => GetProperty(ref _usingQuickHack);
			set => SetProperty(ref _usingQuickHack, value);
		}

		public PlayerCombatControllerActiveFlags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
