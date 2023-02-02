using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrafficGenTrafficSetting : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("meshImpact")] 
		public CEnum<TrafficGenMeshImpact> MeshImpact
		{
			get => GetPropertyValue<CEnum<TrafficGenMeshImpact>>();
			set => SetPropertyValue<CEnum<TrafficGenMeshImpact>>(value);
		}

		public TrafficGenTrafficSetting()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
