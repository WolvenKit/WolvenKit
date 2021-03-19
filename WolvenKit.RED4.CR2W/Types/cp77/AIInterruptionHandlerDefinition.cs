using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerDefinition : LibTreeINodeDefinition
	{
		private AIInterruptionSignal _signal;
		private CBool _supportLessImportantSignals;

		[Ordinal(0)] 
		[RED("signal")] 
		public AIInterruptionSignal Signal
		{
			get => GetProperty(ref _signal);
			set => SetProperty(ref _signal, value);
		}

		[Ordinal(1)] 
		[RED("supportLessImportantSignals")] 
		public CBool SupportLessImportantSignals
		{
			get => GetProperty(ref _supportLessImportantSignals);
			set => SetProperty(ref _supportLessImportantSignals, value);
		}

		public AIInterruptionHandlerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
