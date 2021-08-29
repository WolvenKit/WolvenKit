using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentCollarAreaParams : RedBaseClass
	{
		private CBool _enable;
		private CFloat _radiusInCM;
		private CFloat _radiusForTriangleRemovalInCM;
		private CFloat _offsetFromSkinInCM;
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("radiusInCM")] 
		public CFloat RadiusInCM
		{
			get => GetProperty(ref _radiusInCM);
			set => SetProperty(ref _radiusInCM, value);
		}

		[Ordinal(2)] 
		[RED("radiusForTriangleRemovalInCM")] 
		public CFloat RadiusForTriangleRemovalInCM
		{
			get => GetProperty(ref _radiusForTriangleRemovalInCM);
			set => SetProperty(ref _radiusForTriangleRemovalInCM, value);
		}

		[Ordinal(3)] 
		[RED("offsetFromSkinInCM")] 
		public CFloat OffsetFromSkinInCM
		{
			get => GetProperty(ref _offsetFromSkinInCM);
			set => SetProperty(ref _offsetFromSkinInCM, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
