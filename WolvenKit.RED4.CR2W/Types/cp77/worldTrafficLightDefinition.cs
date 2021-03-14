using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightDefinition : CVariable
	{
		private CFloat _positionOnLane;
		private CUInt32 _groupIdx;
		private CFloat _extent;
		private CArray<worldTrafficLightStage> _timeline;

		[Ordinal(0)] 
		[RED("positionOnLane")] 
		public CFloat PositionOnLane
		{
			get
			{
				if (_positionOnLane == null)
				{
					_positionOnLane = (CFloat) CR2WTypeManager.Create("Float", "positionOnLane", cr2w, this);
				}
				return _positionOnLane;
			}
			set
			{
				if (_positionOnLane == value)
				{
					return;
				}
				_positionOnLane = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get
			{
				if (_groupIdx == null)
				{
					_groupIdx = (CUInt32) CR2WTypeManager.Create("Uint32", "groupIdx", cr2w, this);
				}
				return _groupIdx;
			}
			set
			{
				if (_groupIdx == value)
				{
					return;
				}
				_groupIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("extent")] 
		public CFloat Extent
		{
			get
			{
				if (_extent == null)
				{
					_extent = (CFloat) CR2WTypeManager.Create("Float", "extent", cr2w, this);
				}
				return _extent;
			}
			set
			{
				if (_extent == value)
				{
					return;
				}
				_extent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeline")] 
		public CArray<worldTrafficLightStage> Timeline
		{
			get
			{
				if (_timeline == null)
				{
					_timeline = (CArray<worldTrafficLightStage>) CR2WTypeManager.Create("array:worldTrafficLightStage", "timeline", cr2w, this);
				}
				return _timeline;
			}
			set
			{
				if (_timeline == value)
				{
					return;
				}
				_timeline = value;
				PropertySet(this);
			}
		}

		public worldTrafficLightDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
