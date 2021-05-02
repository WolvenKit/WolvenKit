using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_VisualEffectAtTarget : gameEffectExecutor_Scripted
	{
		private gameFxResource _effect;
		private CBool _ignoreTimeDilation;

		[Ordinal(1)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(2)] 
		[RED("ignoreTimeDilation")] 
		public CBool IgnoreTimeDilation
		{
			get => GetProperty(ref _ignoreTimeDilation);
			set => SetProperty(ref _ignoreTimeDilation, value);
		}

		public EffectExecutor_VisualEffectAtTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
