using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workEquipPropToSlotAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("attachMethod")] 
		public CEnum<workPropAttachMethod> AttachMethod
		{
			get => GetPropertyValue<CEnum<workPropAttachMethod>>();
			set => SetPropertyValue<CEnum<workPropAttachMethod>>(value);
		}

		[Ordinal(3)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public workEquipPropToSlotAction()
		{
			CustomOffsetPos = new Vector3();
			CustomOffsetRot = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
