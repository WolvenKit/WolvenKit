using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnRequest : gameScriptableSystemRequest
	{
		private CEnum<EPreventionHeatStage> _heatStage;

		[Ordinal(0)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetProperty(ref _heatStage);
			set => SetProperty(ref _heatStage, value);
		}

		public PreventionDelayedSpawnRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
