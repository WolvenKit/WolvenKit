using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayBinkDeviceOperation : DeviceOperationBase
	{
		private SBinkperationData _bink;

		[Ordinal(5)] 
		[RED("bink")] 
		public SBinkperationData Bink
		{
			get => GetProperty(ref _bink);
			set => SetProperty(ref _bink, value);
		}

		public PlayBinkDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
