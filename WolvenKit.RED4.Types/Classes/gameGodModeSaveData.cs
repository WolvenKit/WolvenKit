using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGodModeSaveData : ISerializable
	{
		private CArray<gameGodModeSaveEntityData> _gods;

		[Ordinal(0)] 
		[RED("gods")] 
		public CArray<gameGodModeSaveEntityData> Gods
		{
			get => GetProperty(ref _gods);
			set => SetProperty(ref _gods, value);
		}
	}
}
