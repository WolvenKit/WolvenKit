using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataComplexValueNode : gamedataValueDataNode
	{
		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CString> Data
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public gamedataComplexValueNode()
		{
			NodeType = Enums.gamedataDataNodeType.ComplexValue;
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
