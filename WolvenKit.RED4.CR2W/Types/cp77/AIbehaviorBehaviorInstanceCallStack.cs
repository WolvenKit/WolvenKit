using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorInstanceCallStack : CVariable
	{
		private CArray<CUInt32> _resourceHashes;

		[Ordinal(0)] 
		[RED("resourceHashes")] 
		public CArray<CUInt32> ResourceHashes
		{
			get => GetProperty(ref _resourceHashes);
			set => SetProperty(ref _resourceHashes, value);
		}

		public AIbehaviorBehaviorInstanceCallStack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
