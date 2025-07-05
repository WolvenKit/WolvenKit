using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDismembermentAudioEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<entAudioDismembermentPart> BodyPart
		{
			get => GetPropertyValue<CEnum<entAudioDismembermentPart>>();
			set => SetPropertyValue<CEnum<entAudioDismembermentPart>>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public entDismembermentAudioEvent()
		{
			Position = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
