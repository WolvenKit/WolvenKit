using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamPhysics : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("physicsData")] 
		public CHandle<physicsSystemResource> PhysicsData
		{
			get => GetPropertyValue<CHandle<physicsSystemResource>>();
			set => SetPropertyValue<CHandle<physicsSystemResource>>(value);
		}
	}
}
