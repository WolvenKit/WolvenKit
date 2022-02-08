using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleDrawer : ISerializable
	{
		[Ordinal(0)] 
		[RED("pivotOffset")] 
		public CFloat PivotOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
