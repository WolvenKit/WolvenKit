using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnvironmentManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIEnvironmentManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIEnvironmentManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
