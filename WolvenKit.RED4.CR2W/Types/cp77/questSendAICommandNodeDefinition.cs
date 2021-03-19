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
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questAICommandParams> CommandParams
		{
			get => GetProperty(ref _commandParams);
			set => SetProperty(ref _commandParams, value);
		}

		public questSendAICommandNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
