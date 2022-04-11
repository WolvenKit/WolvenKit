using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questChangeVoicesetState_NodeType : questIVoicesetManager_NodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questChangeVoicesetState_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questChangeVoicesetState_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questChangeVoicesetState_NodeTypeParams>>(value);
		}

		public questChangeVoicesetState_NodeType()
		{
			Params = new() { new() };
		}
	}
}
