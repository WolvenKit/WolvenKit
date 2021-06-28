using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereqState : gamePrereqState
	{
		private CArray<CHandle<gamePrereqState>> _nestedStates;

		[Ordinal(0)] 
		[RED("nestedStates")] 
		public CArray<CHandle<gamePrereqState>> NestedStates
		{
			get => GetProperty(ref _nestedStates);
			set => SetProperty(ref _nestedStates, value);
		}

		public gameMultiPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
