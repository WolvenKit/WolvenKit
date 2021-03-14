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
			get
			{
				if (_keys == null)
				{
					_keys = (CArray<gameStatsObjectID>) CR2WTypeManager.Create("array:gameStatsObjectID", "keys", cr2w, this);
				}
				return _keys;
			}
			set
			{
				if (_keys == value)
				{
					return;
				}
				_keys = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameSavedStatsData> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (CArray<gameSavedStatsData>) CR2WTypeManager.Create("array:gameSavedStatsData", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		public gameStatsStateMapStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
