using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputHintGroup_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private TweakDBID _iconID;
		private CName _groupId;
		private CString _localizedTitle;
		private CString _localizedDescription;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get
			{
				if (_groupId == null)
				{
					_groupId = (CName) CR2WTypeManager.Create("CName", "groupId", cr2w, this);
				}
				return _groupId;
			}
			set
			{
				if (_groupId == value)
				{
					return;
				}
				_groupId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localizedTitle")] 
		public CString LocalizedTitle
		{
			get
			{
				if (_localizedTitle == null)
				{
					_localizedTitle = (CString) CR2WTypeManager.Create("String", "localizedTitle", cr2w, this);
				}
				return _localizedTitle;
			}
			set
			{
				if (_localizedTitle == value)
				{
					return;
				}
				_localizedTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get
			{
				if (_localizedDescription == null)
				{
					_localizedDescription = (CString) CR2WTypeManager.Create("String", "localizedDescription", cr2w, this);
				}
				return _localizedDescription;
			}
			set
			{
				if (_localizedDescription == value)
				{
					return;
				}
				_localizedDescription = value;
				PropertySet(this);
			}
		}

		public questInputHintGroup_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
