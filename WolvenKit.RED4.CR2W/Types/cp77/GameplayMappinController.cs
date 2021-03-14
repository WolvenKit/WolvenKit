using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayMappinController : QuestMappinController
	{
		private CHandle<inkanimProxy> _anim;
		private CBool _isVisibleThroughWalls;

		[Ordinal(33)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get
			{
				if (_anim == null)
				{
					_anim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim", cr2w, this);
				}
				return _anim;
			}
			set
			{
				if (_anim == value)
				{
					return;
				}
				_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("isVisibleThroughWalls")] 
		public CBool IsVisibleThroughWalls
		{
			get
			{
				if (_isVisibleThroughWalls == null)
				{
					_isVisibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "isVisibleThroughWalls", cr2w, this);
				}
				return _isVisibleThroughWalls;
			}
			set
			{
				if (_isVisibleThroughWalls == value)
				{
					return;
				}
				_isVisibleThroughWalls = value;
				PropertySet(this);
			}
		}

		public GameplayMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
