using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsStateMapStructure : CVariable
	{
		private CArray<gameStatsObjectID> _keys;
		private CArray<gameSavedStatsData> _values;

		[Ordinal(0)] 
		[RED("keys")] 
		public CArray<gameStatsObjectID> Keys
		{
			get => GetProperty(ref _keys);
			set => SetProperty(ref _keys, value);
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameSavedStatsData> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}

		public gameStatsStateMapStructure(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
