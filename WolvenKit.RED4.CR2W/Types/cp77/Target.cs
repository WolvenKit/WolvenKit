using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Target : IScriptable
	{
		private wCHandle<gameObject> _target;
		private CBool _isInteresting;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target_
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInteresting")] 
		public CBool IsInteresting
		{
			get
			{
				if (_isInteresting == null)
				{
					_isInteresting = (CBool) CR2WTypeManager.Create("Bool", "isInteresting", cr2w, this);
				}
				return _isInteresting;
			}
			set
			{
				if (_isInteresting == value)
				{
					return;
				}
				_isInteresting = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		public Target(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
