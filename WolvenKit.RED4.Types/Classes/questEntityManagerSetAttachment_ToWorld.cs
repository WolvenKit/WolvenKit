using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSetAttachment_ToWorld : questIEntityManagerSetAttachment_NodeSubType
	{
		[Ordinal(0)] 
		[RED("attachmentRef")] 
		public NodeRef AttachmentRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("offsetMode")] 
		public CEnum<questAttachmentOffsetMode> OffsetMode
		{
			get => GetPropertyValue<CEnum<questAttachmentOffsetMode>>();
			set => SetPropertyValue<CEnum<questAttachmentOffsetMode>>(value);
		}

		[Ordinal(2)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public questEntityManagerSetAttachment_ToWorld()
		{
			CustomOffsetPos = new();
			CustomOffsetRot = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
