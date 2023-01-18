using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITargetTrackerComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("threatsSaveData")] 
		public CArray<AIThreatSaveData> ThreatsSaveData
		{
			get => GetPropertyValue<CArray<AIThreatSaveData>>();
			set => SetPropertyValue<CArray<AIThreatSaveData>>(value);
		}

		public AITargetTrackerComponentPS()
		{
			ThreatsSaveData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
