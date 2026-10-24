using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnNodeSymbol : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(1)] 
		[RED("editorNodeId")] 
		public scnNodeId EditorNodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(2)] 
		[RED("editorEventId")] 
		public CUInt64 EditorEventId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnNodeSymbol()
		{
			NodeId = new scnNodeId();
			EditorNodeId = new scnNodeId();
			EditorEventId = ulong.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
