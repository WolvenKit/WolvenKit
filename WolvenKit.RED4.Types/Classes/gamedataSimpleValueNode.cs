using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataSimpleValueNode : gamedataValueDataNode
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataSimpleValueNodeValueType> Type
		{
			get => GetPropertyValue<CEnum<gamedataSimpleValueNodeValueType>>();
			set => SetPropertyValue<CEnum<gamedataSimpleValueNodeValueType>>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gamedataSimpleValueNode()
		{
			NodeType = Enums.gamedataDataNodeType.SimpleValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
