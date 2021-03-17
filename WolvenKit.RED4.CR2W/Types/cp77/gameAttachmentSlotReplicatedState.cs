using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotReplicatedState : CVariable
	{
		private TweakDBID _slotID;
		private gameItemID _activeItemID;
		private CBool _hasItemObject;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get => GetProperty(ref _activeItemID);
			set => SetProperty(ref _activeItemID, value);
		}

		[Ordinal(2)] 
		[RED("hasItemObject")] 
		public CBool HasItemObject
		{
			get => GetProperty(ref _hasItemObject);
			set => SetProperty(ref _hasItemObject, value);
		}

		public gameAttachmentSlotReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
