using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSetAttachment_ToActor : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)] 
		[RED("attachmentRef")] 
		public NodeRef AttachmentRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("slot")] 
		public CName Slot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("offsetMode")] 
		public CEnum<questAttachmentOffsetMode> OffsetMode
		{
			get => GetPropertyValue<CEnum<questAttachmentOffsetMode>>();
			set => SetPropertyValue<CEnum<questAttachmentOffsetMode>>(value);
		}

		[Ordinal(5)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public questEntityManagerSetAttachment_ToActor()
		{
			ObjectRef = new() { Names = new() };
			IsPlayer = true;
			CustomOffsetPos = new();
			CustomOffsetRot = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
