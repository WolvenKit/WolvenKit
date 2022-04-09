using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioSoundComponentSubSystemWrapper : ISerializable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<gameaudioISoundComponentSubSystem> Type
		{
			get => GetPropertyValue<CHandle<gameaudioISoundComponentSubSystem>>();
			set => SetPropertyValue<CHandle<gameaudioISoundComponentSubSystem>>(value);
		}

		public gameaudioSoundComponentSubSystemWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
