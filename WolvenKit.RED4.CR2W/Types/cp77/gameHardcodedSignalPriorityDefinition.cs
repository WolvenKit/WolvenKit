using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		private CArray<CName> _signals;

		[Ordinal(1)] 
		[RED("signals")] 
		public CArray<CName> Signals
		{
			get => GetProperty(ref _signals);
			set => SetProperty(ref _signals, value);
		}

		public gameHardcodedSignalPriorityDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
