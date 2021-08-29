using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNodeSourceChannel_StaticVector : animIAnimNodeSourceChannel_Vector
	{
		private Vector4 _data;

		[Ordinal(0)] 
		[RED("data")] 
		public Vector4 Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
