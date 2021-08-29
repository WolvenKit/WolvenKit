using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayVoiceset_NodeType : questIVoicesetManager_NodeType
	{
		private CArray<questPlayVoiceset_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questPlayVoiceset_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
