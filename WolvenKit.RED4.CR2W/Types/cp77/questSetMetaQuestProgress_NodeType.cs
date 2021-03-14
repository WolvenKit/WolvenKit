using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetMetaQuestProgress_NodeType : questIUIManagerNodeType
	{
		private CEnum<gamedataMetaQuest> _metaQuestId;
		private CUInt32 _percent;
		private LocalizationString _text;

		[Ordinal(0)] 
		[RED("metaQuestId")] 
		public CEnum<gamedataMetaQuest> MetaQuestId
		{
			get
			{
				if (_metaQuestId == null)
				{
					_metaQuestId = (CEnum<gamedataMetaQuest>) CR2WTypeManager.Create("gamedataMetaQuest", "metaQuestId", cr2w, this);
				}
				return _metaQuestId;
			}
			set
			{
				if (_metaQuestId == value)
				{
					return;
				}
				_metaQuestId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get
			{
				if (_percent == null)
				{
					_percent = (CUInt32) CR2WTypeManager.Create("Uint32", "percent", cr2w, this);
				}
				return _percent;
			}
			set
			{
				if (_percent == value)
				{
					return;
				}
				_percent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		public questSetMetaQuestProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
