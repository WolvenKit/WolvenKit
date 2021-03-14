using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameObjectListener : IScriptable
	{
		private CHandle<gamePrereqState> _prereqOwner;
		private CBool _e3HackBlock;

		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get
			{
				if (_prereqOwner == null)
				{
					_prereqOwner = (CHandle<gamePrereqState>) CR2WTypeManager.Create("handle:gamePrereqState", "prereqOwner", cr2w, this);
				}
				return _prereqOwner;
			}
			set
			{
				if (_prereqOwner == value)
				{
					return;
				}
				_prereqOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("e3HackBlock")] 
		public CBool E3HackBlock
		{
			get
			{
				if (_e3HackBlock == null)
				{
					_e3HackBlock = (CBool) CR2WTypeManager.Create("Bool", "e3HackBlock", cr2w, this);
				}
				return _e3HackBlock;
			}
			set
			{
				if (_e3HackBlock == value)
				{
					return;
				}
				_e3HackBlock = value;
				PropertySet(this);
			}
		}

		public GameObjectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
