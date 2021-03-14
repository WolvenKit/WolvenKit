using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuButtonItem : AnimatedListItemController
	{
		private inkTextWidgetReference _fluff;
		private CHandle<inkanimProxy> _animLoop;

		[Ordinal(30)] 
		[RED("Fluff")] 
		public inkTextWidgetReference Fluff
		{
			get
			{
				if (_fluff == null)
				{
					_fluff = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Fluff", cr2w, this);
				}
				return _fluff;
			}
			set
			{
				if (_fluff == value)
				{
					return;
				}
				_fluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get
			{
				if (_animLoop == null)
				{
					_animLoop = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLoop", cr2w, this);
				}
				return _animLoop;
			}
			set
			{
				if (_animLoop == value)
				{
					return;
				}
				_animLoop = value;
				PropertySet(this);
			}
		}

		public PauseMenuButtonItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
