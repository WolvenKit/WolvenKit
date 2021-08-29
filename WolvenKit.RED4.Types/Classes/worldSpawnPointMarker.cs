using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSpawnPointMarker : worldIMarker
	{
		private CUInt32 _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CUInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
