using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockade : CVariable
	{
		private CUInt64 _areaID;
		private CArray<CUInt64> _offmeshLinks;
		private CArray<worldTrafficLaneUID> _affectedTrafficLanes;

		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get
			{
				if (_areaID == null)
				{
					_areaID = (CUInt64) CR2WTypeManager.Create("Uint64", "areaID", cr2w, this);
				}
				return _areaID;
			}
			set
			{
				if (_areaID == value)
				{
					return;
				}
				_areaID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offmeshLinks")] 
		public CArray<CUInt64> OffmeshLinks
		{
			get
			{
				if (_offmeshLinks == null)
				{
					_offmeshLinks = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "offmeshLinks", cr2w, this);
				}
				return _offmeshLinks;
			}
			set
			{
				if (_offmeshLinks == value)
				{
					return;
				}
				_offmeshLinks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("affectedTrafficLanes")] 
		public CArray<worldTrafficLaneUID> AffectedTrafficLanes
		{
			get
			{
				if (_affectedTrafficLanes == null)
				{
					_affectedTrafficLanes = (CArray<worldTrafficLaneUID>) CR2WTypeManager.Create("array:worldTrafficLaneUID", "affectedTrafficLanes", cr2w, this);
				}
				return _affectedTrafficLanes;
			}
			set
			{
				if (_affectedTrafficLanes == value)
				{
					return;
				}
				_affectedTrafficLanes = value;
				PropertySet(this);
			}
		}

		public worldTrafficNullAreaDynamicBlockade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
