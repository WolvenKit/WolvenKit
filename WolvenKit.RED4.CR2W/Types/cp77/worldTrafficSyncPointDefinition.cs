using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSyncPointDefinition : CVariable
	{
		private CArray<NodeRef> _laneRefs;
		private CArray<CFloat> _lanePositions;
		private CFloat _length;

		[Ordinal(0)] 
		[RED("laneRefs")] 
		public CArray<NodeRef> LaneRefs
		{
			get
			{
				if (_laneRefs == null)
				{
					_laneRefs = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "laneRefs", cr2w, this);
				}
				return _laneRefs;
			}
			set
			{
				if (_laneRefs == value)
				{
					return;
				}
				_laneRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lanePositions")] 
		public CArray<CFloat> LanePositions
		{
			get
			{
				if (_lanePositions == null)
				{
					_lanePositions = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "lanePositions", cr2w, this);
				}
				return _lanePositions;
			}
			set
			{
				if (_lanePositions == value)
				{
					return;
				}
				_lanePositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CFloat) CR2WTypeManager.Create("Float", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		public worldTrafficSyncPointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
