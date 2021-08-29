using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamPhysics : meshMeshParameter
	{
		private CHandle<physicsSystemResource> _physicsData;

		[Ordinal(0)] 
		[RED("physicsData")] 
		public CHandle<physicsSystemResource> PhysicsData
		{
			get => GetProperty(ref _physicsData);
			set => SetProperty(ref _physicsData, value);
		}
	}
}
