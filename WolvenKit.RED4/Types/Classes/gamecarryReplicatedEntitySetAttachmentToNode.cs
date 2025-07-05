using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamecarryReplicatedEntitySetAttachmentToNode : netEntityAttachmentInterface
	{
		[Ordinal(1)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public gamecarryReplicatedEntitySetAttachmentToNode()
		{
			LocalTransform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
