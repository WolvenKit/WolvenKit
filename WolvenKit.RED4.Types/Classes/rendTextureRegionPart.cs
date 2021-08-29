using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendTextureRegionPart : ISerializable
	{
		private Vector4 _innerRegion;
		private Vector4 _outerRegion;

		[Ordinal(0)] 
		[RED("innerRegion")] 
		public Vector4 InnerRegion
		{
			get => GetProperty(ref _innerRegion);
			set => SetProperty(ref _innerRegion, value);
		}

		[Ordinal(1)] 
		[RED("outerRegion")] 
		public Vector4 OuterRegion
		{
			get => GetProperty(ref _outerRegion);
			set => SetProperty(ref _outerRegion, value);
		}
	}
}
