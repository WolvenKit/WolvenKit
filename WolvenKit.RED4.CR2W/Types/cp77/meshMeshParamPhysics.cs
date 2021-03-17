using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamPhysics : meshMeshParameter
	{
		private CHandle<physicsSystemResource> _physicsData;

		[Ordinal(0)] 
		[RED("physicsData")] 
		public CHandle<physicsSystemResource> PhysicsData
		{
			get => GetProperty(ref _physicsData);
			set => SetProperty(ref _physicsData, value);
		}

		public meshMeshParamPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
