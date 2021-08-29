using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficSpotDefinition : ISerializable
	{
		private CFloat _length;
		private CEnum<worldTrafficSpotDirection> _direction;

		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<worldTrafficSpotDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
