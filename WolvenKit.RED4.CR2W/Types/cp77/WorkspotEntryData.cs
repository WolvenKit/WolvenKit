using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotEntryData : IScriptable
	{
		private NodeRef _workspotRef;
		private CBool _isEnabled;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get
			{
				if (_workspotRef == null)
				{
					_workspotRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "workspotRef", cr2w, this);
				}
				return _workspotRef;
			}
			set
			{
				if (_workspotRef == value)
				{
					return;
				}
				_workspotRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get
			{
				if (_isAvailable == null)
				{
					_isAvailable = (CBool) CR2WTypeManager.Create("Bool", "isAvailable", cr2w, this);
				}
				return _isAvailable;
			}
			set
			{
				if (_isAvailable == value)
				{
					return;
				}
				_isAvailable = value;
				PropertySet(this);
			}
		}

		public WorkspotEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
