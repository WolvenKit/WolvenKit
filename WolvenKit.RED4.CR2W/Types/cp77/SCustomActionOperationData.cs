using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCustomActionOperationData : CVariable
	{
		private CName _actionID;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		public SCustomActionOperationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
