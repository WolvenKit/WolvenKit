using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questManageCollision_NodeType : questIWorldDataManagerNodeType
	{
		private CArray<questManageCollision_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questManageCollision_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
