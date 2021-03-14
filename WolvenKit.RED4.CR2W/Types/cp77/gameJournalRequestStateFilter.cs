using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestStateFilter : CVariable
	{
		private CBool _inactive;
		private CBool _active;
		private CBool _succeeded;
		private CBool _failed;

		[Ordinal(0)] 
		[RED("inactive")] 
		public CBool Inactive
		{
			get
			{
				if (_inactive == null)
				{
					_inactive = (CBool) CR2WTypeManager.Create("Bool", "inactive", cr2w, this);
				}
				return _inactive;
			}
			set
			{
				if (_inactive == value)
				{
					return;
				}
				_inactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("succeeded")] 
		public CBool Succeeded
		{
			get
			{
				if (_succeeded == null)
				{
					_succeeded = (CBool) CR2WTypeManager.Create("Bool", "succeeded", cr2w, this);
				}
				return _succeeded;
			}
			set
			{
				if (_succeeded == value)
				{
					return;
				}
				_succeeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("failed")] 
		public CBool Failed
		{
			get
			{
				if (_failed == null)
				{
					_failed = (CBool) CR2WTypeManager.Create("Bool", "failed", cr2w, this);
				}
				return _failed;
			}
			set
			{
				if (_failed == value)
				{
					return;
				}
				_failed = value;
				PropertySet(this);
			}
		}

		public gameJournalRequestStateFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
