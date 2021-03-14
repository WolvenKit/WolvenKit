using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCommandCondition : AIbehaviorexpressionScript
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CUInt32 _cmdCbId;

		[Ordinal(0)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get
			{
				if (_commandName == null)
				{
					_commandName = (CName) CR2WTypeManager.Create("CName", "commandName", cr2w, this);
				}
				return _commandName;
			}
			set
			{
				if (_commandName == value)
				{
					return;
				}
				_commandName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get
			{
				if (_useInheritance == null)
				{
					_useInheritance = (CBool) CR2WTypeManager.Create("Bool", "useInheritance", cr2w, this);
				}
				return _useInheritance;
			}
			set
			{
				if (_useInheritance == value)
				{
					return;
				}
				_useInheritance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get
			{
				if (_cmdCbId == null)
				{
					_cmdCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "cmdCbId", cr2w, this);
				}
				return _cmdCbId;
			}
			set
			{
				if (_cmdCbId == value)
				{
					return;
				}
				_cmdCbId = value;
				PropertySet(this);
			}
		}

		public PassiveCommandCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
