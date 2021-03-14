using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaGroupingSettings : CVariable
	{
		private CName _groupCountTag;
		private CName _groupCountRtpc;
		private CName _groupAvgDistanceRtpc;
		private CEnum<audioAmbientGroupingVariant> _groupingVariant;
		private CFloat _minDistance;
		private CFloat _maxDistance;

		[Ordinal(0)] 
		[RED("GroupCountTag")] 
		public CName GroupCountTag
		{
			get
			{
				if (_groupCountTag == null)
				{
					_groupCountTag = (CName) CR2WTypeManager.Create("CName", "GroupCountTag", cr2w, this);
				}
				return _groupCountTag;
			}
			set
			{
				if (_groupCountTag == value)
				{
					return;
				}
				_groupCountTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("GroupCountRtpc")] 
		public CName GroupCountRtpc
		{
			get
			{
				if (_groupCountRtpc == null)
				{
					_groupCountRtpc = (CName) CR2WTypeManager.Create("CName", "GroupCountRtpc", cr2w, this);
				}
				return _groupCountRtpc;
			}
			set
			{
				if (_groupCountRtpc == value)
				{
					return;
				}
				_groupCountRtpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("GroupAvgDistanceRtpc")] 
		public CName GroupAvgDistanceRtpc
		{
			get
			{
				if (_groupAvgDistanceRtpc == null)
				{
					_groupAvgDistanceRtpc = (CName) CR2WTypeManager.Create("CName", "GroupAvgDistanceRtpc", cr2w, this);
				}
				return _groupAvgDistanceRtpc;
			}
			set
			{
				if (_groupAvgDistanceRtpc == value)
				{
					return;
				}
				_groupAvgDistanceRtpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("groupingVariant")] 
		public CEnum<audioAmbientGroupingVariant> GroupingVariant
		{
			get
			{
				if (_groupingVariant == null)
				{
					_groupingVariant = (CEnum<audioAmbientGroupingVariant>) CR2WTypeManager.Create("audioAmbientGroupingVariant", "groupingVariant", cr2w, this);
				}
				return _groupingVariant;
			}
			set
			{
				if (_groupingVariant == value)
				{
					return;
				}
				_groupingVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("MinDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "MinDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("MaxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "MaxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		public audioAmbientAreaGroupingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
