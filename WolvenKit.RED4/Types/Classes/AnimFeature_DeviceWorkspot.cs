using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DeviceWorkspot : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("e3_lockInReferencePose")] 
		public CBool E3_lockInReferencePose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_DeviceWorkspot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
