using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamecarryReplicatedEntitySetAttachmentToWorld : netEntityAttachmentInterface
	{
		[Ordinal(1)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public gamecarryReplicatedEntitySetAttachmentToWorld()
		{
			LocalTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
