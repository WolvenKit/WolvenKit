using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseActionOperations : DeviceOperations
	{
		private CArray<SBaseActionOperationData> _baseActionsOperations;

		[Ordinal(2)] 
		[RED("baseActionsOperations")] 
		public CArray<SBaseActionOperationData> BaseActionsOperations
		{
			get => GetProperty(ref _baseActionsOperations);
			set => SetProperty(ref _baseActionsOperations, value);
		}

		public BaseActionOperations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
