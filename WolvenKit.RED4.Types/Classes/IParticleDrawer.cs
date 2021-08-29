using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleDrawer : ISerializable
	{
		private CFloat _pivotOffset;

		[Ordinal(0)] 
		[RED("pivotOffset")] 
		public CFloat PivotOffset
		{
			get => GetProperty(ref _pivotOffset);
			set => SetProperty(ref _pivotOffset, value);
		}
	}
}
