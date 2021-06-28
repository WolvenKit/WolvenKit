using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipPropToSlotAction : workIWorkspotItemAction
	{
		private CName _itemId;
		private TweakDBID _itemSlot;
		private CEnum<workPropAttachMethod> _attachMethod;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetProperty(ref _itemSlot);
			set => SetProperty(ref _itemSlot, value);
		}

		[Ordinal(2)] 
		[RED("attachMethod")] 
		public CEnum<workPropAttachMethod> AttachMethod
		{
			get => GetProperty(ref _attachMethod);
			set => SetProperty(ref _attachMethod, value);
		}

		[Ordinal(3)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetProperty(ref _customOffsetPos);
			set => SetProperty(ref _customOffsetPos, value);
		}

		[Ordinal(4)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetProperty(ref _customOffsetRot);
			set => SetProperty(ref _customOffsetRot, value);
		}

		public workEquipPropToSlotAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
