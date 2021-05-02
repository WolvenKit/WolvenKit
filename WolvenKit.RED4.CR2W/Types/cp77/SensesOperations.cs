using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensesOperations : DeviceOperations
	{
		private CArray<SSensesOperationData> _sensesOperations;

		[Ordinal(2)] 
		[RED("sensesOperations")] 
		public CArray<SSensesOperationData> SensesOperations_
		{
			get => GetProperty(ref _sensesOperations);
			set => SetProperty(ref _sensesOperations, value);
		}

		public SensesOperations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
