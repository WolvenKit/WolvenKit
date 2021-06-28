using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRequestVehicleCameraPerspective_NodeType : questIVehicleManagerNodeType
	{
		private CEnum<questVehicleCameraPerspective> _cameraPerspective;

		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<questVehicleCameraPerspective> CameraPerspective
		{
			get => GetProperty(ref _cameraPerspective);
			set => SetProperty(ref _cameraPerspective, value);
		}

		public questRequestVehicleCameraPerspective_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
