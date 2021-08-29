using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questIAudioNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIAudioNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
