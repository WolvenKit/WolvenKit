using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChatter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("voicesetComponent")] 
		public CWeakHandle<scnVoicesetComponent> VoicesetComponent
		{
			get => GetPropertyValue<CWeakHandle<scnVoicesetComponent>>();
			set => SetPropertyValue<CWeakHandle<scnVoicesetComponent>>(value);
		}

		public scnChatter()
		{
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
