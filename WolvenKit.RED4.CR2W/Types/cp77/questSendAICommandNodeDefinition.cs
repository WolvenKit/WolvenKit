using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSendAICommandNodeDefinition : questAICommandNodeBase
	{
		private gameEntityReference _puppet;
		private CHandle<questAICommandParams> _commandParams;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questAICommandParams> CommandParams
		{
			get
			{
				if (_commandParams == null)
				{
					_commandParams = (CHandle<questAICommandParams>) CR2WTypeManager.Create("handle:questAICommandParams", "commandParams", cr2w, this);
				}
				return _commandParams;
			}
			set
			{
				if (_commandParams == value)
				{
					return;
				}
				_commandParams = value;
				PropertySet(this);
			}
		}

		public questSendAICommandNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
