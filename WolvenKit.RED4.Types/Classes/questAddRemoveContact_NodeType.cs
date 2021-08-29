using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddRemoveContact_NodeType : questIPhoneManagerNodeType
	{
		private CArray<questChangeContactList_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questChangeContactList_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
