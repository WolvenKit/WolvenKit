using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuCursorUserData : inkUserData
	{
		private CName _animationOverride;
		private CArray<CName> _actions;

		[Ordinal(0)] 
		[RED("animationOverride")] 
		public CName AnimationOverride
		{
			get
			{
				if (_animationOverride == null)
				{
					_animationOverride = (CName) CR2WTypeManager.Create("CName", "animationOverride", cr2w, this);
				}
				return _animationOverride;
			}
			set
			{
				if (_animationOverride == value)
				{
					return;
				}
				_animationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CName> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		public MenuCursorUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
