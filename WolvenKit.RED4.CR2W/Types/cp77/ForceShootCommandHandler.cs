using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceShootCommandHandler : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIForceShootCommand> _currentCommand;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get
			{
				if (_inCommand == null)
				{
					_inCommand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inCommand", cr2w, this);
				}
				return _inCommand;
			}
			set
			{
				if (_inCommand == value)
				{
					return;
				}
				_inCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public wCHandle<AIForceShootCommand> CurrentCommand
		{
			get
			{
				if (_currentCommand == null)
				{
					_currentCommand = (wCHandle<AIForceShootCommand>) CR2WTypeManager.Create("whandle:AIForceShootCommand", "currentCommand", cr2w, this);
				}
				return _currentCommand;
			}
			set
			{
				if (_currentCommand == value)
				{
					return;
				}
				_currentCommand = value;
				PropertySet(this);
			}
		}

		public ForceShootCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
