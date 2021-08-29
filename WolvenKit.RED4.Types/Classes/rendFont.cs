using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendFont : CResource
	{
		private DataBuffer _fontBuffer;

		[Ordinal(1)] 
		[RED("fontBuffer")] 
		public DataBuffer FontBuffer
		{
			get => GetProperty(ref _fontBuffer);
			set => SetProperty(ref _fontBuffer, value);
		}
	}
}
