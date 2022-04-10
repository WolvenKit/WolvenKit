using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNodeEditorData : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("globalName")] 
		public CString GlobalName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("alternativeGlobalName")] 
		public CString AlternativeGlobalName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("isGlobalNameLocked")] 
		public CBool IsGlobalNameLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isAlternativeGlobalNameLocked")] 
		public CBool IsAlternativeGlobalNameLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isDestructibleNode")] 
		public CBool IsDestructibleNode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("shouldSkipStreamingInEditor")] 
		public CBool ShouldSkipStreamingInEditor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("excludeOnConsole")] 
		public CBool ExcludeOnConsole
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("proxyMeshDependency")] 
		public CEnum<worldProxyMeshDependencyMode> ProxyMeshDependency
		{
			get => GetPropertyValue<CEnum<worldProxyMeshDependencyMode>>();
			set => SetPropertyValue<CEnum<worldProxyMeshDependencyMode>>(value);
		}

		[Ordinal(10)] 
		[RED("transform")] 
		public worldNodeTransform Transform
		{
			get => GetPropertyValue<worldNodeTransform>();
			set => SetPropertyValue<worldNodeTransform>(value);
		}

		[Ordinal(11)] 
		[RED("pivotTransform")] 
		public Transform PivotTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(12)] 
		[RED("variantId")] 
		public CUInt32 VariantId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("questPrefabRefHash")] 
		public CUInt64 QuestPrefabRefHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(14)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isSnapTarget")] 
		public CBool IsSnapTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isSnapSource")] 
		public CBool IsSnapSource
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("maxStreamingDistance")] 
		public CFloat MaxStreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldNodeEditorData()
		{
			Name = "node";
			Transform = new() { Translation = new(), Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F } };
			PivotTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			IsSnapTarget = true;
			IsSnapSource = true;
			MaxStreamingDistance = 340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
