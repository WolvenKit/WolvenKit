using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MoveToCoverCommandTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIMoveToCoverCommand> _currentCommand;
		private CUInt64 _coverID;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public wCHandle<AIMoveToCoverCommand> CurrentCommand
		{
			get => GetProperty(ref _currentCommand);
			set => SetProperty(ref _currentCommand, value);
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CUInt64 CoverID
		{
			get => GetProperty(ref _coverID);
			set => SetProperty(ref _coverID, value);
		}

		public MoveToCoverCommandTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
