using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayVoiceset_NodeType : questIVoicesetManager_NodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questPlayVoiceset_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questPlayVoiceset_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questPlayVoiceset_NodeTypeParams>>(value);
		}

		public questPlayVoiceset_NodeType()
		{
			Params = new() { new questPlayVoiceset_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
