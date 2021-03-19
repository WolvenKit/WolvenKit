using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimDeviceOperation : DeviceOperationBase
	{
		private CArray<SStimOperationData> _stims;

		[Ordinal(5)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetProperty(ref _stims);
			set => SetProperty(ref _stims, value);
		}

		public StimDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
