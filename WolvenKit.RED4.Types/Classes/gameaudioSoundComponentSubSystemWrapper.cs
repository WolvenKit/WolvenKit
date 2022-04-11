using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioSoundComponentSubSystemWrapper : ISerializable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<gameaudioISoundComponentSubSystem> Type
		{
			get => GetPropertyValue<CHandle<gameaudioISoundComponentSubSystem>>();
			set => SetPropertyValue<CHandle<gameaudioISoundComponentSubSystem>>(value);
		}
	}
}
