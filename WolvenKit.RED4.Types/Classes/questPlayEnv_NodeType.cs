using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayEnv_NodeType : questIEnvironmentManagerNodeType
	{
		private questPlayEnv_NodeTypeParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public questPlayEnv_NodeTypeParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
