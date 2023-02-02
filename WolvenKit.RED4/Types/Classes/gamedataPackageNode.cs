using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataPackageNode : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("serializedVariables")] 
		public CArray<CHandle<gamedataVariableNode>> SerializedVariables
		{
			get => GetPropertyValue<CArray<CHandle<gamedataVariableNode>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataVariableNode>>>(value);
		}

		[Ordinal(2)] 
		[RED("serializedGroups")] 
		public CArray<CHandle<gamedataGroupNode>> SerializedGroups
		{
			get => GetPropertyValue<CArray<CHandle<gamedataGroupNode>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataGroupNode>>>(value);
		}

		[Ordinal(3)] 
		[RED("files")] 
		public CArray<CHandle<gamedataFileNode>> Files
		{
			get => GetPropertyValue<CArray<CHandle<gamedataFileNode>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataFileNode>>>(value);
		}

		public gamedataPackageNode()
		{
			SerializedVariables = new();
			SerializedGroups = new();
			Files = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
