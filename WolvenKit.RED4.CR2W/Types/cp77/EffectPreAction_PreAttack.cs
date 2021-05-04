using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectPreAction_PreAttack : gameEffectPreAction_Scripted
	{
		private CBool _withFriendlyFire;
		private CBool _withSelfDamage;

		[Ordinal(0)] 
		[RED("withFriendlyFire")] 
		public CBool WithFriendlyFire
		{
			get => GetProperty(ref _withFriendlyFire);
			set => SetProperty(ref _withFriendlyFire, value);
		}

		[Ordinal(1)] 
		[RED("withSelfDamage")] 
		public CBool WithSelfDamage
		{
			get => GetProperty(ref _withSelfDamage);
			set => SetProperty(ref _withSelfDamage, value);
		}

		public EffectPreAction_PreAttack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
