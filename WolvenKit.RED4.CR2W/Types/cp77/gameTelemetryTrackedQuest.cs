using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryTrackedQuest : CVariable
	{
		private CString _name;
		private CString _objectiveName;
		private CString _type;
		private CFloat _distance;
		private CString _questName;
		private CString _questType;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectiveName")] 
		public CString ObjectiveName
		{
			get
			{
				if (_objectiveName == null)
				{
					_objectiveName = (CString) CR2WTypeManager.Create("String", "objectiveName", cr2w, this);
				}
				return _objectiveName;
			}
			set
			{
				if (_objectiveName == value)
				{
					return;
				}
				_objectiveName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CString Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CString) CR2WTypeManager.Create("String", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("questName")] 
		public CString QuestName
		{
			get
			{
				if (_questName == null)
				{
					_questName = (CString) CR2WTypeManager.Create("String", "questName", cr2w, this);
				}
				return _questName;
			}
			set
			{
				if (_questName == value)
				{
					return;
				}
				_questName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("questType")] 
		public CString QuestType
		{
			get
			{
				if (_questType == null)
				{
					_questType = (CString) CR2WTypeManager.Create("String", "questType", cr2w, this);
				}
				return _questType;
			}
			set
			{
				if (_questType == value)
				{
					return;
				}
				_questType = value;
				PropertySet(this);
			}
		}

		public gameTelemetryTrackedQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
