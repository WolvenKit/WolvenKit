using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAcousticPortalNode : worldNode
	{
		private CUInt8 _radius;
		private CUInt8 _nominalRadius;

		[Ordinal(4)] 
		[RED("radius")] 
		public CUInt8 Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(5)] 
		[RED("nominalRadius")] 
		public CUInt8 NominalRadius
		{
			get => GetProperty(ref _nominalRadius);
			set => SetProperty(ref _nominalRadius, value);
		}
	}
}
