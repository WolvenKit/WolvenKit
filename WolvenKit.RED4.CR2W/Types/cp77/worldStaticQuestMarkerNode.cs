using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticQuestMarkerNode : worldNode
	{
		private CEnum<worldQuestType> _questType;
		private CString _questLabel;
		private CFloat _questMarkerHeight;

		[Ordinal(4)] 
		[RED("questType")] 
		public CEnum<worldQuestType> QuestType
		{
			get
			{
				if (_questType == null)
				{
					_questType = (CEnum<worldQuestType>) CR2WTypeManager.Create("worldQuestType", "questType", cr2w, this);
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

		[Ordinal(5)] 
		[RED("questLabel")] 
		public CString QuestLabel
		{
			get
			{
				if (_questLabel == null)
				{
					_questLabel = (CString) CR2WTypeManager.Create("String", "questLabel", cr2w, this);
				}
				return _questLabel;
			}
			set
			{
				if (_questLabel == value)
				{
					return;
				}
				_questLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("questMarkerHeight")] 
		public CFloat QuestMarkerHeight
		{
			get
			{
				if (_questMarkerHeight == null)
				{
					_questMarkerHeight = (CFloat) CR2WTypeManager.Create("Float", "questMarkerHeight", cr2w, this);
				}
				return _questMarkerHeight;
			}
			set
			{
				if (_questMarkerHeight == value)
				{
					return;
				}
				_questMarkerHeight = value;
				PropertySet(this);
			}
		}

		public worldStaticQuestMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
