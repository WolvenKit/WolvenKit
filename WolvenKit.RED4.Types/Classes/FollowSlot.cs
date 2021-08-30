using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FollowSlot : IScriptable
	{
		private CInt32 _id;
		private Transform _slotTransform;
		private CBool _isEnabled;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("slotTransform")] 
		public Transform SlotTransform
		{
			get => GetProperty(ref _slotTransform);
			set => SetProperty(ref _slotTransform, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(3)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		public FollowSlot()
		{
			_isEnabled = true;
			_isAvailable = true;
		}
	}
}
