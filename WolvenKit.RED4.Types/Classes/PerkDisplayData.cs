using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkDisplayData : BasePerkDisplayData
	{
		private CEnum<gamedataPerkArea> _area;
		private CEnum<gamedataPerkType> _type;

		[Ordinal(10)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
