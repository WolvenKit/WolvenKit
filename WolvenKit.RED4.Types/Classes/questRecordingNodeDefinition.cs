using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRecordingNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRecordingNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIRecordingNodeType>>();
			set => SetPropertyValue<CHandle<questIRecordingNodeType>>(value);
		}

		public questRecordingNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
