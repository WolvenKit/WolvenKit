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
			get
			{
				if (_cameraPerspective == null)
				{
					_cameraPerspective = (CEnum<questVehicleCameraPerspective>) CR2WTypeManager.Create("questVehicleCameraPerspective", "cameraPerspective", cr2w, this);
				}
				return _cameraPerspective;
			}
			set
			{
				if (_cameraPerspective == value)
				{
					return;
				}
				_cameraPerspective = value;
				PropertySet(this);
			}
		}

		public questRequestVehicleCameraPerspective_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
