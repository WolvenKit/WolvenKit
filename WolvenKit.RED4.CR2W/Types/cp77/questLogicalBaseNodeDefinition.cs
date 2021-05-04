using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CUInt32 _inputSocketCount;
		private CUInt32 _outputSocketCount;

		[Ordinal(2)] 
		[RED("inputSocketCount")] 
		public CUInt32 InputSocketCount
		{
			get => GetProperty(ref _inputSocketCount);
			set => SetProperty(ref _inputSocketCount, value);
		}

		[Ordinal(3)] 
		[RED("outputSocketCount")] 
		public CUInt32 OutputSocketCount
		{
			get => GetProperty(ref _outputSocketCount);
			set => SetProperty(ref _outputSocketCount, value);
		}

		public questLogicalBaseNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
