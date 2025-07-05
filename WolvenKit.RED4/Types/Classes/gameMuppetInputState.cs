using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMuppetInputState()
		{
			FrameId = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
