using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRecordingNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIRecordingNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRecordingNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
