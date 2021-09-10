using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			TweakDBRecord = new() { Value = 80645782896 };
			TweakDBDescriptionRecord = new() { Value = 130097364595 };
		}
	}
}
