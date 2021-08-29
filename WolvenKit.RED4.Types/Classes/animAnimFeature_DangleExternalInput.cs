using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_DangleExternalInput : animAnimFeature
	{
		private Vector4 _fictitiousAccelerationWs;

		[Ordinal(0)] 
		[RED("fictitiousAccelerationWs")] 
		public Vector4 FictitiousAccelerationWs
		{
			get => GetProperty(ref _fictitiousAccelerationWs);
			set => SetProperty(ref _fictitiousAccelerationWs, value);
		}
	}
}
