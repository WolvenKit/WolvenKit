using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams : CVariable
	{
		private CHandle<questUniversalRef> _objectRef;
		private CArray<questInjectLoot_NodeTypeParams_OperationData> _operations;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("operations")] 
		public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations
		{
			get => GetProperty(ref _operations);
			set => SetProperty(ref _operations, value);
		}

		public questInjectLoot_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
