using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackPhase : questdbgCallstackBlock
	{
		private CArray<CUInt64> _phases;
		private CArray<CUInt64> _blocks;

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CUInt64> Phases
		{
			get => GetProperty(ref _phases);
			set => SetProperty(ref _phases, value);
		}

		[Ordinal(3)] 
		[RED("blocks")] 
		public CArray<CUInt64> Blocks
		{
			get => GetProperty(ref _blocks);
			set => SetProperty(ref _blocks, value);
		}

		public questdbgCallstackPhase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
