using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeExecutor_Heal : gameEffectExecutor_Scripted
	{
		private CFloat _healthPerc;

		[Ordinal(1)] 
		[RED("healthPerc")] 
		public CFloat HealthPerc
		{
			get => GetProperty(ref _healthPerc);
			set => SetProperty(ref _healthPerc, value);
		}

		public StrikeExecutor_Heal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
