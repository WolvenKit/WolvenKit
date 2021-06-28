using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperations : DeviceOperations
	{
		private CArray<SFocusModeOperationData> _focusModeOperations;

		[Ordinal(2)] 
		[RED("focusModeOperations")] 
		public CArray<SFocusModeOperationData> FocusModeOperations_
		{
			get => GetProperty(ref _focusModeOperations);
			set => SetProperty(ref _focusModeOperations, value);
		}

		public FocusModeOperations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
