using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerDestroyCarriedObject : questIEntityManagerSetAttachment_NodeSubType
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

		public questEntityManagerDestroyCarriedObject()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			IsPlayer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
