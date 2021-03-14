using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetLocationName_NodeType : questIUIManagerNodeType
	{
		private CString _locationName;
		private CEnum<questLocationAction> _action;
		private TweakDBID _districtID;
		private CBool _isNewLocation;

		[Ordinal(0)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (CString) CR2WTypeManager.Create("String", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<questLocationAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questLocationAction>) CR2WTypeManager.Create("questLocationAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get
			{
				if (_districtID == null)
				{
					_districtID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "districtID", cr2w, this);
				}
				return _districtID;
			}
			set
			{
				if (_districtID == value)
				{
					return;
				}
				_districtID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isNewLocation")] 
		public CBool IsNewLocation
		{
			get
			{
				if (_isNewLocation == null)
				{
					_isNewLocation = (CBool) CR2WTypeManager.Create("Bool", "isNewLocation", cr2w, this);
				}
				return _isNewLocation;
			}
			set
			{
				if (_isNewLocation == value)
				{
					return;
				}
				_isNewLocation = value;
				PropertySet(this);
			}
		}

		public questSetLocationName_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
