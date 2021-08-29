using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataGroupNode : gamedataDataNode
	{
		private CString _name;
		private CString _base;
		private CString _schema;
		private CBool _isInline;
		private CWeakHandle<gamedataGroupNode> _baseGroup;
		private CWeakHandle<gamedataGroupNode> _schemaGroup;
		private CWeakHandle<gamedataPackageNode> _package;
		private CHandle<gamedataFileNode> _fileNode;
		private CUInt32 _inlineGroupId;
		private CEnum<gamedataGroupNodeInheritanceState> _inheritanceState;
		private CArray<gamedataGroupNodeGroupVariable> _serializedVariables;
		private CArray<CName> _tags;

		[Ordinal(3)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(4)] 
		[RED("base")] 
		public CString Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}

		[Ordinal(5)] 
		[RED("schema")] 
		public CString Schema
		{
			get => GetProperty(ref _schema);
			set => SetProperty(ref _schema, value);
		}

		[Ordinal(6)] 
		[RED("isInline")] 
		public CBool IsInline
		{
			get => GetProperty(ref _isInline);
			set => SetProperty(ref _isInline, value);
		}

		[Ordinal(7)] 
		[RED("baseGroup")] 
		public CWeakHandle<gamedataGroupNode> BaseGroup
		{
			get => GetProperty(ref _baseGroup);
			set => SetProperty(ref _baseGroup, value);
		}

		[Ordinal(8)] 
		[RED("schemaGroup")] 
		public CWeakHandle<gamedataGroupNode> SchemaGroup
		{
			get => GetProperty(ref _schemaGroup);
			set => SetProperty(ref _schemaGroup, value);
		}

		[Ordinal(9)] 
		[RED("package")] 
		public CWeakHandle<gamedataPackageNode> Package
		{
			get => GetProperty(ref _package);
			set => SetProperty(ref _package, value);
		}

		[Ordinal(10)] 
		[RED("fileNode")] 
		public CHandle<gamedataFileNode> FileNode
		{
			get => GetProperty(ref _fileNode);
			set => SetProperty(ref _fileNode, value);
		}

		[Ordinal(11)] 
		[RED("inlineGroupId")] 
		public CUInt32 InlineGroupId
		{
			get => GetProperty(ref _inlineGroupId);
			set => SetProperty(ref _inlineGroupId, value);
		}

		[Ordinal(12)] 
		[RED("inheritanceState")] 
		public CEnum<gamedataGroupNodeInheritanceState> InheritanceState
		{
			get => GetProperty(ref _inheritanceState);
			set => SetProperty(ref _inheritanceState, value);
		}

		[Ordinal(13)] 
		[RED("serializedVariables")] 
		public CArray<gamedataGroupNodeGroupVariable> SerializedVariables
		{
			get => GetProperty(ref _serializedVariables);
			set => SetProperty(ref _serializedVariables, value);
		}

		[Ordinal(14)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}
	}
}
