using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHackingManager_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CHandle<questHackingManager_ActionType>> Actions
		{
			get => GetPropertyValue<CArray<CHandle<questHackingManager_ActionType>>>();
			set => SetPropertyValue<CArray<CHandle<questHackingManager_ActionType>>>(value);
		}

		public questHackingManager_NodeTypeParams()
		{
			Actions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
