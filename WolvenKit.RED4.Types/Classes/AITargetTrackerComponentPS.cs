using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITargetTrackerComponentPS : gameComponentPS
	{
		private CArray<AIThreatSaveData> _threatsSaveData;

		[Ordinal(0)] 
		[RED("threatsSaveData")] 
		public CArray<AIThreatSaveData> ThreatsSaveData
		{
			get => GetProperty(ref _threatsSaveData);
			set => SetProperty(ref _threatsSaveData, value);
		}
	}
}
