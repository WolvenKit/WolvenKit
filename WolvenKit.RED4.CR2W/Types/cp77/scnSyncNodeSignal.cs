using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSyncNodeSignal : CVariable
	{
		private CUInt32 _nodeId;
		private CUInt16 _name;
		private CUInt16 _ordinal;
		private CUInt16 _numRuns;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CUInt32 NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get => GetProperty(ref _ordinal);
			set => SetProperty(ref _ordinal, value);
		}

		[Ordinal(3)] 
		[RED("numRuns")] 
		public CUInt16 NumRuns
		{
			get => GetProperty(ref _numRuns);
			set => SetProperty(ref _numRuns, value);
		}

		public scnSyncNodeSignal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
