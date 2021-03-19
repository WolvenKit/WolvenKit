using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _command;
		private CHandle<AIArgumentMapping> _outWorkspotData;

		[Ordinal(1)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(2)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetProperty(ref _outWorkspotData);
			set => SetProperty(ref _outWorkspotData, value);
		}

		public AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
