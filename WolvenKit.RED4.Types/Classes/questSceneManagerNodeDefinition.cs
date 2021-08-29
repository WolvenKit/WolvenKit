using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questISceneManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questISceneManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
