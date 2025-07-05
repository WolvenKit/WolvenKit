using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questNPCLookAt_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("lookAtTargetRef")] 
		public gameEntityReference LookAtTargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("assignLookAt")] 
		public CBool AssignLookAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("refPlayer")] 
		public CBool RefPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questNPCLookAt_NodeType()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			LookAtTargetRef = new gameEntityReference { Names = new() };
			AssignLookAt = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
