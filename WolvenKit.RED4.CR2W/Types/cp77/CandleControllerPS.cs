using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CandleControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _candleSkillChecks;

		[Ordinal(103)] 
		[RED("candleSkillChecks")] 
		public CHandle<EngDemoContainer> CandleSkillChecks
		{
			get => GetProperty(ref _candleSkillChecks);
			set => SetProperty(ref _candleSkillChecks, value);
		}

		public CandleControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
