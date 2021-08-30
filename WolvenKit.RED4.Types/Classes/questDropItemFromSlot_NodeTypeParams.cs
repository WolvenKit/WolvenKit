using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDropItemFromSlot_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _objectRef;
		private TweakDBID _slotId;
		private CBool _useGravity;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("useGravity")] 
		public CBool UseGravity
		{
			get => GetProperty(ref _useGravity);
			set => SetProperty(ref _useGravity, value);
		}

		public questDropItemFromSlot_NodeTypeParams()
		{
			_useGravity = true;
		}
	}
}
