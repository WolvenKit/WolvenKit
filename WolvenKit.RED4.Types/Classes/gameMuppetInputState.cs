using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputState : RedBaseClass
	{
		private CUInt32 _frameId;

		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetProperty(ref _frameId);
			set => SetProperty(ref _frameId, value);
		}
	}
}
