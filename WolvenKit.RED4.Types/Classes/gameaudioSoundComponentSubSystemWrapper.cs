using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioSoundComponentSubSystemWrapper : ISerializable
	{
		private CHandle<gameaudioISoundComponentSubSystem> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<gameaudioISoundComponentSubSystem> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
