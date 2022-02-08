using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkVideoData : ISerializable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<gameBinkVideoRecord> Data
		{
			get => GetPropertyValue<CArray<gameBinkVideoRecord>>();
			set => SetPropertyValue<CArray<gameBinkVideoRecord>>(value);
		}

		public gameBinkVideoData()
		{
			Data = new();
		}
	}
}
