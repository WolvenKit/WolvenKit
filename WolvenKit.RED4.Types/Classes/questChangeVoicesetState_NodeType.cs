using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questChangeVoicesetState_NodeType : questIVoicesetManager_NodeType
	{
		private CArray<questChangeVoicesetState_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questChangeVoicesetState_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
