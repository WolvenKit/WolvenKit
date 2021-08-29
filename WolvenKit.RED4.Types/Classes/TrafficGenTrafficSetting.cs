using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficGenTrafficSetting : RedBaseClass
	{
		private CEnum<TrafficGenMeshImpact> _meshImpact;

		[Ordinal(0)] 
		[RED("meshImpact")] 
		public CEnum<TrafficGenMeshImpact> MeshImpact
		{
			get => GetProperty(ref _meshImpact);
			set => SetProperty(ref _meshImpact, value);
		}
	}
}
