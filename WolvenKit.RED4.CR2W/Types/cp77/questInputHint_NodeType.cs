using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputHint_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CName _action;
		private CName _groupId;
		private CString _localizedLabel;

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
		[RED("action")] 
		public CName Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CName) CR2WTypeManager.Create("CName", "action", cr2w, this);
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
		[RED("localizedLabel")] 
		public CString LocalizedLabel
		{
			get
			{
				if (_localizedLabel == null)
				{
					_localizedLabel = (CString) CR2WTypeManager.Create("String", "localizedLabel", cr2w, this);
				}
				return _localizedLabel;
			}
			set
			{
				if (_localizedLabel == value)
				{
					return;
				}
				_localizedLabel = value;
				PropertySet(this);
			}
		}

		public questInputHint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
