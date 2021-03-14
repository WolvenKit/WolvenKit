using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFormConvoy_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _leaderRef;
		private CEnum<vehicleFormationType> _formationType;

		[Ordinal(0)] 
		[RED("leaderRef")] 
		public gameEntityReference LeaderRef
		{
			get
			{
				if (_leaderRef == null)
				{
					_leaderRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "leaderRef", cr2w, this);
				}
				return _leaderRef;
			}
			set
			{
				if (_leaderRef == value)
				{
					return;
				}
				_leaderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("formationType")] 
		public CEnum<vehicleFormationType> FormationType
		{
			get
			{
				if (_formationType == null)
				{
					_formationType = (CEnum<vehicleFormationType>) CR2WTypeManager.Create("vehicleFormationType", "formationType", cr2w, this);
				}
				return _formationType;
			}
			set
			{
				if (_formationType == value)
				{
					return;
				}
				_formationType = value;
				PropertySet(this);
			}
		}

		public questFormConvoy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
