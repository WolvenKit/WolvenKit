using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAssignConvoy_NodeType : questIVehicleManagerNodeType
	{
		private CArray<gameEntityReference> _followers;
		private gameEntityReference _vehicleLeaderRef;

		[Ordinal(0)] 
		[RED("Followers")] 
		public CArray<gameEntityReference> Followers
		{
			get
			{
				if (_followers == null)
				{
					_followers = (CArray<gameEntityReference>) CR2WTypeManager.Create("array:gameEntityReference", "Followers", cr2w, this);
				}
				return _followers;
			}
			set
			{
				if (_followers == value)
				{
					return;
				}
				_followers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleLeaderRef")] 
		public gameEntityReference VehicleLeaderRef
		{
			get
			{
				if (_vehicleLeaderRef == null)
				{
					_vehicleLeaderRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleLeaderRef", cr2w, this);
				}
				return _vehicleLeaderRef;
			}
			set
			{
				if (_vehicleLeaderRef == value)
				{
					return;
				}
				_vehicleLeaderRef = value;
				PropertySet(this);
			}
		}

		public questAssignConvoy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
