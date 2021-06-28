using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		private CArray<SDamageOperationData> _damages;

		[Ordinal(5)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetProperty(ref _damages);
			set => SetProperty(ref _damages, value);
		}

		public ApplyDamageDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
