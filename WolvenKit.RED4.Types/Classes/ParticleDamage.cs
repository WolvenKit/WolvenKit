using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ParticleDamage : ISerializable
	{
		private CArray<Box> _boundingBoxes;

		[Ordinal(0)] 
		[RED("boundingBoxes")] 
		public CArray<Box> BoundingBoxes
		{
			get => GetProperty(ref _boundingBoxes);
			set => SetProperty(ref _boundingBoxes, value);
		}
	}
}
