using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MetaQuestStatus : CVariable
	{
		private CBool _metaQuest1Hidden;
		private CInt32 _metaQuest1Value;
		private CString _metaQuest1Description;
		private CBool _metaQuest2Hidden;
		private CString _metaQuest2Description;
		private CInt32 _metaQuest2Value;
		private CBool _metaQuest3Hidden;
		private CString _metaQuest3Description;
		private CInt32 _metaQuest3Value;

		[Ordinal(0)] 
		[RED("MetaQuest1Hidden")] 
		public CBool MetaQuest1Hidden
		{
			get
			{
				if (_metaQuest1Hidden == null)
				{
					_metaQuest1Hidden = (CBool) CR2WTypeManager.Create("Bool", "MetaQuest1Hidden", cr2w, this);
				}
				return _metaQuest1Hidden;
			}
			set
			{
				if (_metaQuest1Hidden == value)
				{
					return;
				}
				_metaQuest1Hidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("MetaQuest1Value")] 
		public CInt32 MetaQuest1Value
		{
			get
			{
				if (_metaQuest1Value == null)
				{
					_metaQuest1Value = (CInt32) CR2WTypeManager.Create("Int32", "MetaQuest1Value", cr2w, this);
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

		[Ordinal(2)] 
		[RED("MetaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get
			{
				if (_metaQuest1Description == null)
				{
					_metaQuest1Description = (CString) CR2WTypeManager.Create("String", "MetaQuest1Description", cr2w, this);
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

		[Ordinal(3)] 
		[RED("MetaQuest2Hidden")] 
		public CBool MetaQuest2Hidden
		{
			get
			{
				if (_metaQuest2Hidden == null)
				{
					_metaQuest2Hidden = (CBool) CR2WTypeManager.Create("Bool", "MetaQuest2Hidden", cr2w, this);
				}
				return _metaQuest2Hidden;
			}
			set
			{
				if (_metaQuest2Hidden == value)
				{
					return;
				}
				_metaQuest2Hidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("MetaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get
			{
				if (_metaQuest2Description == null)
				{
					_metaQuest2Description = (CString) CR2WTypeManager.Create("String", "MetaQuest2Description", cr2w, this);
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

		[Ordinal(5)] 
		[RED("MetaQuest2Value")] 
		public CInt32 MetaQuest2Value
		{
			get
			{
				if (_metaQuest2Value == null)
				{
					_metaQuest2Value = (CInt32) CR2WTypeManager.Create("Int32", "MetaQuest2Value", cr2w, this);
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

		[Ordinal(6)] 
		[RED("MetaQuest3Hidden")] 
		public CBool MetaQuest3Hidden
		{
			get
			{
				if (_metaQuest3Hidden == null)
				{
					_metaQuest3Hidden = (CBool) CR2WTypeManager.Create("Bool", "MetaQuest3Hidden", cr2w, this);
				}
				return _metaQuest3Hidden;
			}
			set
			{
				if (_metaQuest3Hidden == value)
				{
					return;
				}
				_metaQuest3Hidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("MetaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get
			{
				if (_metaQuest3Description == null)
				{
					_metaQuest3Description = (CString) CR2WTypeManager.Create("String", "MetaQuest3Description", cr2w, this);
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

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public CInt32 MetaQuest3Value
		{
			get
			{
				if (_metaQuest3Value == null)
				{
					_metaQuest3Value = (CInt32) CR2WTypeManager.Create("Int32", "MetaQuest3Value", cr2w, this);
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

		public MetaQuestStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
