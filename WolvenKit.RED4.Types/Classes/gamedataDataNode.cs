using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataDataNode : ISerializable
	{
		[Ordinal(0)] 
		[RED("nodeType")] 
		public CEnum<gamedataDataNodeType> NodeType
		{
			get => GetPropertyValue<CEnum<gamedataDataNodeType>>();
			set => SetPropertyValue<CEnum<gamedataDataNodeType>>(value);
		}

		[Ordinal(1)] 
		[RED("fileName")] 
		public CString FileName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public CWeakHandle<gamedataDataNode> Parent
		{
			get => GetPropertyValue<CWeakHandle<gamedataDataNode>>();
			set => SetPropertyValue<CWeakHandle<gamedataDataNode>>(value);
		}

		public gamedataDataNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
