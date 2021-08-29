using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePingComponent : entIPlacedComponent
	{
		private CEnum<gamedataPingType> _associatedPingType;

		[Ordinal(5)] 
		[RED("associatedPingType")] 
		public CEnum<gamedataPingType> AssociatedPingType
		{
			get => GetProperty(ref _associatedPingType);
			set => SetProperty(ref _associatedPingType, value);
		}
	}
}
