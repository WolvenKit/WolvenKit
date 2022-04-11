using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddRemoveContact_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questChangeContactList_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questChangeContactList_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questChangeContactList_NodeTypeParams>>(value);
		}

		public questAddRemoveContact_NodeType()
		{
			Params = new() { new() };
		}
	}
}
