using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayEnv_NodeType : questIEnvironmentManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public questPlayEnv_NodeTypeParams Params
		{
			get => GetPropertyValue<questPlayEnv_NodeTypeParams>();
			set => SetPropertyValue<questPlayEnv_NodeTypeParams>(value);
		}

		public questPlayEnv_NodeType()
		{
			Params = new() { Enable = true };
		}
	}
}
