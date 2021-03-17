using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsSystemSave : ISerializable
	{
		private CArray<gameStatsSeedKey> _statsObjectsData;
		private CArray<gameStatModifierSave> _statModifiersData;

		[Ordinal(0)] 
		[RED("statsObjectsData")] 
		public CArray<gameStatsSeedKey> StatsObjectsData
		{
			get => GetProperty(ref _statsObjectsData);
			set => SetProperty(ref _statsObjectsData, value);
		}

		[Ordinal(1)] 
		[RED("statModifiersData")] 
		public CArray<gameStatModifierSave> StatModifiersData
		{
			get => GetProperty(ref _statModifiersData);
			set => SetProperty(ref _statModifiersData, value);
		}

		public gameStatsSystemSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
