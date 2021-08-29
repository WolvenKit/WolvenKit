using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectSlotEntry : RedBaseClass
	{
		private CName _slotName;
		private Vector3 _relativePosition;
		private Quaternion _relativeRotation;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get => GetProperty(ref _relativePosition);
			set => SetProperty(ref _relativePosition, value);
		}

		[Ordinal(2)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get => GetProperty(ref _relativeRotation);
			set => SetProperty(ref _relativeRotation, value);
		}
	}
}
