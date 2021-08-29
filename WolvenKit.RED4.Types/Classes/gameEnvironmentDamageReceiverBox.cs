using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEnvironmentDamageReceiverBox : gameEnvironmentDamageReceiverShape
	{
		private Vector3 _dimensions;

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}
	}
}
