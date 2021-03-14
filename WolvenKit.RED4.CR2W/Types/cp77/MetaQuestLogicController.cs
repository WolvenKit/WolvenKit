using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MetaQuestLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _metaQuestHint;
		private inkTextWidgetReference _metaQuestHintText;
		private inkWidgetReference _metaQuest1;
		private inkWidgetReference _metaQuest2;
		private inkWidgetReference _metaQuest3;
		private inkTextWidgetReference _metaQuest1Value;
		private inkTextWidgetReference _metaQuest2Value;
		private inkTextWidgetReference _metaQuest3Value;
		private CString _metaQuest1Description;
		private CString _metaQuest2Description;
		private CString _metaQuest3Description;
		private CHandle<inkanimProxy> _animMeta1;
		private CHandle<inkanimProxy> _animMeta2;
		private CHandle<inkanimProxy> _animMeta3;
		private CHandle<inkanimProxy> _animTooltip;

		[Ordinal(1)] 
		[RED("MetaQuestHint")] 
		public inkWidgetReference MetaQuestHint
		{
			get
			{
				if (_metaQuestHint == null)
				{
					_metaQuestHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MetaQuestHint", cr2w, this);
				}
				return _metaQuestHint;
			}
			set
			{
				if (_metaQuestHint == value)
				{
					return;
				}
				_metaQuestHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("MetaQuestHintText")] 
		public inkTextWidgetReference MetaQuestHintText
		{
			get
			{
				if (_metaQuestHintText == null)
				{
					_metaQuestHintText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MetaQuestHintText", cr2w, this);
				}
				return _metaQuestHintText;
			}
			set
			{
				if (_metaQuestHintText == value)
				{
					return;
				}
				_metaQuestHintText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("MetaQuest1")] 
		public inkWidgetReference MetaQuest1
		{
			get
			{
				if (_metaQuest1 == null)
				{
					_metaQuest1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MetaQuest1", cr2w, this);
				}
				return _metaQuest1;
			}
			set
			{
				if (_metaQuest1 == value)
				{
					return;
				}
				_metaQuest1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("MetaQuest2")] 
		public inkWidgetReference MetaQuest2
		{
			get
			{
				if (_metaQuest2 == null)
				{
					_metaQuest2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MetaQuest2", cr2w, this);
				}
				return _metaQuest2;
			}
			set
			{
				if (_metaQuest2 == value)
				{
					return;
				}
				_metaQuest2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("MetaQuest3")] 
		public inkWidgetReference MetaQuest3
		{
			get
			{
				if (_metaQuest3 == null)
				{
					_metaQuest3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MetaQuest3", cr2w, this);
				}
				return _metaQuest3;
			}
			set
			{
				if (_metaQuest3 == value)
				{
					return;
				}
				_metaQuest3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("MetaQuest1Value")] 
		public inkTextWidgetReference MetaQuest1Value
		{
			get
			{
				if (_metaQuest1Value == null)
				{
					_metaQuest1Value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MetaQuest1Value", cr2w, this);
				}
				return _metaQuest1Value;
			}
			set
			{
				if (_metaQuest1Value == value)
				{
					return;
				}
				_metaQuest1Value = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("MetaQuest2Value")] 
		public inkTextWidgetReference MetaQuest2Value
		{
			get
			{
				if (_metaQuest2Value == null)
				{
					_metaQuest2Value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MetaQuest2Value", cr2w, this);
				}
				return _metaQuest2Value;
			}
			set
			{
				if (_metaQuest2Value == value)
				{
					return;
				}
				_metaQuest2Value = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public inkTextWidgetReference MetaQuest3Value
		{
			get
			{
				if (_metaQuest3Value == null)
				{
					_metaQuest3Value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MetaQuest3Value", cr2w, this);
				}
				return _metaQuest3Value;
			}
			set
			{
				if (_metaQuest3Value == value)
				{
					return;
				}
				_metaQuest3Value = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("metaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get
			{
				if (_metaQuest1Description == null)
				{
					_metaQuest1Description = (CString) CR2WTypeManager.Create("String", "metaQuest1Description", cr2w, this);
				}
				return _metaQuest1Description;
			}
			set
			{
				if (_metaQuest1Description == value)
				{
					return;
				}
				_metaQuest1Description = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("metaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get
			{
				if (_metaQuest2Description == null)
				{
					_metaQuest2Description = (CString) CR2WTypeManager.Create("String", "metaQuest2Description", cr2w, this);
				}
				return _metaQuest2Description;
			}
			set
			{
				if (_metaQuest2Description == value)
				{
					return;
				}
				_metaQuest2Description = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("metaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get
			{
				if (_metaQuest3Description == null)
				{
					_metaQuest3Description = (CString) CR2WTypeManager.Create("String", "metaQuest3Description", cr2w, this);
				}
				return _metaQuest3Description;
			}
			set
			{
				if (_metaQuest3Description == value)
				{
					return;
				}
				_metaQuest3Description = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animMeta1")] 
		public CHandle<inkanimProxy> AnimMeta1
		{
			get
			{
				if (_animMeta1 == null)
				{
					_animMeta1 = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animMeta1", cr2w, this);
				}
				return _animMeta1;
			}
			set
			{
				if (_animMeta1 == value)
				{
					return;
				}
				_animMeta1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animMeta2")] 
		public CHandle<inkanimProxy> AnimMeta2
		{
			get
			{
				if (_animMeta2 == null)
				{
					_animMeta2 = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animMeta2", cr2w, this);
				}
				return _animMeta2;
			}
			set
			{
				if (_animMeta2 == value)
				{
					return;
				}
				_animMeta2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animMeta3")] 
		public CHandle<inkanimProxy> AnimMeta3
		{
			get
			{
				if (_animMeta3 == null)
				{
					_animMeta3 = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animMeta3", cr2w, this);
				}
				return _animMeta3;
			}
			set
			{
				if (_animMeta3 == value)
				{
					return;
				}
				_animMeta3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animTooltip")] 
		public CHandle<inkanimProxy> AnimTooltip
		{
			get
			{
				if (_animTooltip == null)
				{
					_animTooltip = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animTooltip", cr2w, this);
				}
				return _animTooltip;
			}
			set
			{
				if (_animTooltip == value)
				{
					return;
				}
				_animTooltip = value;
				PropertySet(this);
			}
		}

		public MetaQuestLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
