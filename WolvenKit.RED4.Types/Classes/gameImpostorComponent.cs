using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameImpostorComponent : entIComponent
	{
		private CBool _isCharacterReplica;
		private CBool _addHead;
		private CBool _ignorePlayerHeadSlot;
		private CArray<TweakDBID> _slotIDsToOmit;

		[Ordinal(3)] 
		[RED("isCharacterReplica")] 
		public CBool IsCharacterReplica
		{
			get => GetProperty(ref _isCharacterReplica);
			set => SetProperty(ref _isCharacterReplica, value);
		}

		[Ordinal(4)] 
		[RED("addHead")] 
		public CBool AddHead
		{
			get => GetProperty(ref _addHead);
			set => SetProperty(ref _addHead, value);
		}

		[Ordinal(5)] 
		[RED("ignorePlayerHeadSlot")] 
		public CBool IgnorePlayerHeadSlot
		{
			get => GetProperty(ref _ignorePlayerHeadSlot);
			set => SetProperty(ref _ignorePlayerHeadSlot, value);
		}

		[Ordinal(6)] 
		[RED("slotIDsToOmit")] 
		public CArray<TweakDBID> SlotIDsToOmit
		{
			get => GetProperty(ref _slotIDsToOmit);
			set => SetProperty(ref _slotIDsToOmit, value);
		}
	}
}
