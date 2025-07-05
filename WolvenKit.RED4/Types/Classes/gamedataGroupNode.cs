using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataGroupNode : gamedataDataNode
	{
		[Ordinal(3)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("base")] 
		public CString Base
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("schema")] 
		public CString Schema
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("isInline")] 
		public CBool IsInline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("baseGroup")] 
		public CWeakHandle<gamedataGroupNode> BaseGroup
		{
			get => GetPropertyValue<CWeakHandle<gamedataGroupNode>>();
			set => SetPropertyValue<CWeakHandle<gamedataGroupNode>>(value);
		}

		[Ordinal(8)] 
		[RED("schemaGroup")] 
		public CWeakHandle<gamedataGroupNode> SchemaGroup
		{
			get => GetPropertyValue<CWeakHandle<gamedataGroupNode>>();
			set => SetPropertyValue<CWeakHandle<gamedataGroupNode>>(value);
		}

		[Ordinal(9)] 
		[RED("package")] 
		public CWeakHandle<gamedataPackageNode> Package
		{
			get => GetPropertyValue<CWeakHandle<gamedataPackageNode>>();
			set => SetPropertyValue<CWeakHandle<gamedataPackageNode>>(value);
		}

		[Ordinal(10)] 
		[RED("fileNode")] 
		public CHandle<gamedataFileNode> FileNode
		{
			get => GetPropertyValue<CHandle<gamedataFileNode>>();
			set => SetPropertyValue<CHandle<gamedataFileNode>>(value);
		}

		[Ordinal(11)] 
		[RED("inlineGroupId")] 
		public CUInt32 InlineGroupId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("inheritanceState")] 
		public CEnum<gamedataGroupNodeInheritanceState> InheritanceState
		{
			get => GetPropertyValue<CEnum<gamedataGroupNodeInheritanceState>>();
			set => SetPropertyValue<CEnum<gamedataGroupNodeInheritanceState>>(value);
		}

		[Ordinal(13)] 
		[RED("serializedVariables")] 
		public CArray<gamedataGroupNodeGroupVariable> SerializedVariables
		{
			get => GetPropertyValue<CArray<gamedataGroupNodeGroupVariable>>();
			set => SetPropertyValue<CArray<gamedataGroupNodeGroupVariable>>(value);
		}

		[Ordinal(14)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gamedataGroupNode()
		{
			NodeType = Enums.gamedataDataNodeType.Group;
			SerializedVariables = new();
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
