using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		private CName _runAnimation;
		private CName _jumpAnimation;
		private CHandle<inkanimProxy> _currentAnimation;

		[Ordinal(1)] 
		[RED("runAnimation")] 
		public CName RunAnimation
		{
			get
			{
				if (_runAnimation == null)
				{
					_runAnimation = (CName) CR2WTypeManager.Create("CName", "runAnimation", cr2w, this);
				}
				return _runAnimation;
			}
			set
			{
				if (_runAnimation == value)
				{
					return;
				}
				_runAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("jumpAnimation")] 
		public CName JumpAnimation
		{
			get
			{
				if (_jumpAnimation == null)
				{
					_jumpAnimation = (CName) CR2WTypeManager.Create("CName", "jumpAnimation", cr2w, this);
				}
				return _jumpAnimation;
			}
			set
			{
				if (_jumpAnimation == value)
				{
					return;
				}
				_jumpAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentAnimation")] 
		public CHandle<inkanimProxy> CurrentAnimation
		{
			get
			{
				if (_currentAnimation == null)
				{
					_currentAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "currentAnimation", cr2w, this);
				}
				return _currentAnimation;
			}
			set
			{
				if (_currentAnimation == value)
				{
					return;
				}
				_currentAnimation = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRacePlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
