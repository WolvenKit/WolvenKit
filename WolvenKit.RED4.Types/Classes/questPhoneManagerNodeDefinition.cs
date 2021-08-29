using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questIPhoneManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIPhoneManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
