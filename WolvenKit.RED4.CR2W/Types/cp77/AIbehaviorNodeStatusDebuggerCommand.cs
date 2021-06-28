using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		private CUInt32 _behaviorResourceHash;
		private CUInt32 _generation;
		private CArray<AIbehaviorNodeStatusDebuggerCommandEntry> _entries;

		[Ordinal(0)] 
		[RED("behaviorResourceHash")] 
		public CUInt32 BehaviorResourceHash
		{
			get => GetProperty(ref _behaviorResourceHash);
			set => SetProperty(ref _behaviorResourceHash, value);
		}

		[Ordinal(1)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get => GetProperty(ref _generation);
			set => SetProperty(ref _generation, value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<AIbehaviorNodeStatusDebuggerCommandEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public AIbehaviorNodeStatusDebuggerCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
