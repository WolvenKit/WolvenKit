using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LevelUpdateEvent : redEvent
	{
		private CInt32 _lvl;
		private CEnum<gamedataProficiencyType> _type;
		private CArray<SDevelopmentPoints> _devPoints;

		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get => GetProperty(ref _lvl);
			set => SetProperty(ref _lvl, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get => GetProperty(ref _devPoints);
			set => SetProperty(ref _devPoints, value);
		}
	}
}
