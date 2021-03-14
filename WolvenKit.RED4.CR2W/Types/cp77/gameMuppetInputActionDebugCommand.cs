using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionDebugCommand : gameIMuppetInputAction
	{
		private CEnum<gameMuppetDebugCommand> _debugCommand;

		[Ordinal(0)] 
		[RED("debugCommand")] 
		public CEnum<gameMuppetDebugCommand> DebugCommand
		{
			get
			{
				if (_debugCommand == null)
				{
					_debugCommand = (CEnum<gameMuppetDebugCommand>) CR2WTypeManager.Create("gameMuppetDebugCommand", "debugCommand", cr2w, this);
				}
				return _debugCommand;
			}
			set
			{
				if (_debugCommand == value)
				{
					return;
				}
				_debugCommand = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionDebugCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
