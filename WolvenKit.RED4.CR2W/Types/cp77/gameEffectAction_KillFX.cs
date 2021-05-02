using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_KillFX : gameEffectAction
	{
		private CEnum<gameEffectAction_KillFXAction> _action;
		private CName _effectTag;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectAction_KillFXAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		public gameEffectAction_KillFX(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
