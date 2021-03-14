using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneConnections : CVariable
	{
		private CArray<worldTrafficConnectivityOutLane> _outlanes;
		private CArray<worldTrafficConnectivityInLane> _inLanes;

		[Ordinal(0)] 
		[RED("outlanes")] 
		public CArray<worldTrafficConnectivityOutLane> Outlanes
		{
			get
			{
				if (_outlanes == null)
				{
					_outlanes = (CArray<worldTrafficConnectivityOutLane>) CR2WTypeManager.Create("array:worldTrafficConnectivityOutLane", "outlanes", cr2w, this);
				}
				return _outlanes;
			}
			set
			{
				if (_outlanes == value)
				{
					return;
				}
				_outlanes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get
			{
				if (_inLanes == null)
				{
					_inLanes = (CArray<worldTrafficConnectivityInLane>) CR2WTypeManager.Create("array:worldTrafficConnectivityInLane", "inLanes", cr2w, this);
				}
				return _inLanes;
			}
			set
			{
				if (_inLanes == value)
				{
					return;
				}
				_inLanes = value;
				PropertySet(this);
			}
		}

		public worldTrafficPersistentLaneConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
