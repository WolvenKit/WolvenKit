using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneGraph : ISerializable
	{
		[Ordinal(0)] 
		[RED("graph")] 
		public CArray<CHandle<scnSceneGraphNode>> Graph
		{
			get => GetPropertyValue<CArray<CHandle<scnSceneGraphNode>>>();
			set => SetPropertyValue<CArray<CHandle<scnSceneGraphNode>>>(value);
		}

		[Ordinal(1)] 
		[RED("startNodes")] 
		public CArray<scnNodeId> StartNodes
		{
			get => GetPropertyValue<CArray<scnNodeId>>();
			set => SetPropertyValue<CArray<scnNodeId>>(value);
		}

		[Ordinal(2)] 
		[RED("endNodes")] 
		public CArray<scnNodeId> EndNodes
		{
			get => GetPropertyValue<CArray<scnNodeId>>();
			set => SetPropertyValue<CArray<scnNodeId>>(value);
		}

		public scnSceneGraph()
		{
			Graph = new();
			StartNodes = new();
			EndNodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
