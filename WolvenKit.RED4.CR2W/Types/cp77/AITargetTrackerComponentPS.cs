using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITargetTrackerComponentPS : gameComponentPS
	{
		private CArray<AIThreatSaveData> _threatsSaveData;

		[Ordinal(0)] 
		[RED("threatsSaveData")] 
		public CArray<AIThreatSaveData> ThreatsSaveData
		{
			get => GetProperty(ref _threatsSaveData);
			set => SetProperty(ref _threatsSaveData, value);
		}

		public AITargetTrackerComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
