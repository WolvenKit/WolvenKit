using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MuteArm : gameweaponObject
	{
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffectInstance;

		[Ordinal(62)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetProperty(ref _gameEffectRef);
			set => SetProperty(ref _gameEffectRef, value);
		}

		[Ordinal(63)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get => GetProperty(ref _gameEffectInstance);
			set => SetProperty(ref _gameEffectInstance, value);
		}

		public MuteArm(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
