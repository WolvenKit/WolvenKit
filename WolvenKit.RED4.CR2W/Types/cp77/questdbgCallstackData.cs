using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackData : CVariable
	{
		private CUInt64 _resourceHash;
		private CArray<questdbgCallstackPhase> _phases;
		private CArray<questdbgCallstackBlock> _blocks;
		private CArray<CUInt64> _executed;
		private CArray<CUInt64> _failed;
		private CUInt32 _callstackRevision;

		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get => GetProperty(ref _resourceHash);
			set => SetProperty(ref _resourceHash, value);
		}

		[Ordinal(1)] 
		[RED("phases")] 
		public CArray<questdbgCallstackPhase> Phases
		{
			get => GetProperty(ref _phases);
			set => SetProperty(ref _phases, value);
		}

		[Ordinal(2)] 
		[RED("blocks")] 
		public CArray<questdbgCallstackBlock> Blocks
		{
			get => GetProperty(ref _blocks);
			set => SetProperty(ref _blocks, value);
		}

		[Ordinal(3)] 
		[RED("executed")] 
		public CArray<CUInt64> Executed
		{
			get => GetProperty(ref _executed);
			set => SetProperty(ref _executed, value);
		}

		[Ordinal(4)] 
		[RED("failed")] 
		public CArray<CUInt64> Failed
		{
			get => GetProperty(ref _failed);
			set => SetProperty(ref _failed, value);
		}

		[Ordinal(5)] 
		[RED("callstackRevision")] 
		public CUInt32 CallstackRevision
		{
			get => GetProperty(ref _callstackRevision);
			set => SetProperty(ref _callstackRevision, value);
		}

		public questdbgCallstackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
