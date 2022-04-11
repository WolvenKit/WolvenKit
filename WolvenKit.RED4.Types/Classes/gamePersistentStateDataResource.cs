using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePersistentStateDataResource : CResource
	{
		[Ordinal(1)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}
	}
}
