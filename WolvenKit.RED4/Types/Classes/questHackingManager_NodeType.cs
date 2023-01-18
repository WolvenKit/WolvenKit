using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHackingManager_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questHackingManager_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questHackingManager_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questHackingManager_NodeTypeParams>>(value);
		}

		public questHackingManager_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
