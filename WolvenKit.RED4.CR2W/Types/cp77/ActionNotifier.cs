using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionNotifier : IScriptable
	{
		private CBool _external;
		private CBool _internal;
		private CBool _failed;

		[Ordinal(0)] 
		[RED("external")] 
		public CBool External
		{
			get
			{
				if (_external == null)
				{
					_external = (CBool) CR2WTypeManager.Create("Bool", "external", cr2w, this);
				}
				return _external;
			}
			set
			{
				if (_external == value)
				{
					return;
				}
				_external = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("internal")] 
		public CBool Internal
		{
			get
			{
				if (_internal == null)
				{
					_internal = (CBool) CR2WTypeManager.Create("Bool", "internal", cr2w, this);
				}
				return _internal;
			}
			set
			{
				if (_internal == value)
				{
					return;
				}
				_internal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public ActionNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
