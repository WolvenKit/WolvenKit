using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingQueryDataResource : CResource
	{
		private CArray<worldStreamingQueryRoadData> _roadDatas;
		private CArray<CUInt16> _connectedRoadDataIndices;

		[Ordinal(1)] 
		[RED("roadDatas")] 
		public CArray<worldStreamingQueryRoadData> RoadDatas
		{
			get
			{
				if (_roadDatas == null)
				{
					_roadDatas = (CArray<worldStreamingQueryRoadData>) CR2WTypeManager.Create("array:worldStreamingQueryRoadData", "roadDatas", cr2w, this);
				}
				return _roadDatas;
			}
			set
			{
				if (_roadDatas == value)
				{
					return;
				}
				_roadDatas = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("connectedRoadDataIndices")] 
		public CArray<CUInt16> ConnectedRoadDataIndices
		{
			get
			{
				if (_connectedRoadDataIndices == null)
				{
					_connectedRoadDataIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "connectedRoadDataIndices", cr2w, this);
				}
				return _connectedRoadDataIndices;
			}
			set
			{
				if (_connectedRoadDataIndices == value)
				{
					return;
				}
				_connectedRoadDataIndices = value;
				PropertySet(this);
			}
		}

		public worldStreamingQueryDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
