using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePersistentStateDataResource : CResource
	{
		private DataBuffer _buffer;

		[Ordinal(1)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}
	}
}
