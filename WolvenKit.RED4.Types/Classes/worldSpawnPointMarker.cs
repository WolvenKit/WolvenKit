using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSpawnPointMarker : worldIMarker
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CUInt32 Type
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
