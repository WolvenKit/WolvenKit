using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		private CBool _onlyWithPlayerInstigator;

		[Ordinal(1)] 
		[RED("onlyWithPlayerInstigator")] 
		public CBool OnlyWithPlayerInstigator
		{
			get => GetProperty(ref _onlyWithPlayerInstigator);
			set => SetProperty(ref _onlyWithPlayerInstigator, value);
		}

		public gameEffectExecutor_TerminateGameEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
