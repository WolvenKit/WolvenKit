using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockadeData : ISerializable
	{
		private CArray<worldTrafficNullAreaDynamicBlockade> _nullAreasBlockades;

		[Ordinal(0)] 
		[RED("nullAreasBlockades")] 
		public CArray<worldTrafficNullAreaDynamicBlockade> NullAreasBlockades
		{
			get
			{
				if (_nullAreasBlockades == null)
				{
					_nullAreasBlockades = (CArray<worldTrafficNullAreaDynamicBlockade>) CR2WTypeManager.Create("array:worldTrafficNullAreaDynamicBlockade", "nullAreasBlockades", cr2w, this);
				}
				return _nullAreasBlockades;
			}
			set
			{
				if (_nullAreasBlockades == value)
				{
					return;
				}
				_nullAreasBlockades = value;
				PropertySet(this);
			}
		}

		public worldTrafficNullAreaDynamicBlockadeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
