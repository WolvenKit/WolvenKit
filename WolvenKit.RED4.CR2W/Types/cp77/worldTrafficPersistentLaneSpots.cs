using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneSpots : CVariable
	{
		private CArray<CHandle<worldTrafficSpotCompiled>> _spots;

		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotCompiled>> Spots
		{
			get
			{
				if (_spots == null)
				{
					_spots = (CArray<CHandle<worldTrafficSpotCompiled>>) CR2WTypeManager.Create("array:handle:worldTrafficSpotCompiled", "spots", cr2w, this);
				}
				return _spots;
			}
			set
			{
				if (_spots == value)
				{
					return;
				}
				_spots = value;
				PropertySet(this);
			}
		}

		public worldTrafficPersistentLaneSpots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
