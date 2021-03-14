using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		private CUInt32 _crowdCreationIndex;
		private CUInt32 _parkingSpaceId;

		[Ordinal(4)] 
		[RED("crowdCreationIndex")] 
		public CUInt32 CrowdCreationIndex
		{
			get
			{
				if (_crowdCreationIndex == null)
				{
					_crowdCreationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "crowdCreationIndex", cr2w, this);
				}
				return _crowdCreationIndex;
			}
			set
			{
				if (_crowdCreationIndex == value)
				{
					return;
				}
				_crowdCreationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("parkingSpaceId")] 
		public CUInt32 ParkingSpaceId
		{
			get
			{
				if (_parkingSpaceId == null)
				{
					_parkingSpaceId = (CUInt32) CR2WTypeManager.Create("Uint32", "parkingSpaceId", cr2w, this);
				}
				return _parkingSpaceId;
			}
			set
			{
				if (_parkingSpaceId == value)
				{
					return;
				}
				_parkingSpaceId = value;
				PropertySet(this);
			}
		}

		public worldCompiledCrowdParkingSpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
