using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkVideoData : ISerializable
	{
		private CArray<gameBinkVideoRecord> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<gameBinkVideoRecord> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
