using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectRootEntry : RedBaseClass
	{
		private Vector3 _relativePosition;
		private Quaternion _relativeRotation;

		[Ordinal(0)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get => GetProperty(ref _relativePosition);
			set => SetProperty(ref _relativePosition, value);
		}

		[Ordinal(1)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get => GetProperty(ref _relativeRotation);
			set => SetProperty(ref _relativeRotation, value);
		}
	}
}
