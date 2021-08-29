using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		private Quaternion _offset;

		[Ordinal(0)] 
		[RED("offset")] 
		public Quaternion Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
