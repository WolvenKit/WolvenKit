using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetTriggerState_NodeType : questITriggerManagerNodeType
	{
		private CArray<questSetTriggerState_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetTriggerState_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
