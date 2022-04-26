using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HoloDeviceControllerPS()
		{
			TweakDBRecord = 80645782896;
			TweakDBDescriptionRecord = 130097364595;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
