using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questResetContainers_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("containerNodeRef")] 
		public NodeRef ContainerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("clearReinitData")] 
		public CBool ClearReinitData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questResetContainers_NodeTypeParams()
		{
			ClearReinitData = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
