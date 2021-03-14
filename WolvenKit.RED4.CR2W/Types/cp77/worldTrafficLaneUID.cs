using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneUID : CVariable
	{
		private CUInt64 _nodeRefHash;
		private CUInt16 _laneNumber;
		private CUInt16 _seqNumber;
		private CBool _isReversed;

		[Ordinal(0)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get
			{
				if (_nodeRefHash == null)
				{
					_nodeRefHash = (CUInt64) CR2WTypeManager.Create("Uint64", "nodeRefHash", cr2w, this);
				}
				return _nodeRefHash;
			}
			set
			{
				if (_nodeRefHash == value)
				{
					return;
				}
				_nodeRefHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get
			{
				if (_laneNumber == null)
				{
					_laneNumber = (CUInt16) CR2WTypeManager.Create("Uint16", "laneNumber", cr2w, this);
				}
				return _laneNumber;
			}
			set
			{
				if (_laneNumber == value)
				{
					return;
				}
				_laneNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get
			{
				if (_seqNumber == null)
				{
					_seqNumber = (CUInt16) CR2WTypeManager.Create("Uint16", "seqNumber", cr2w, this);
				}
				return _seqNumber;
			}
			set
			{
				if (_seqNumber == value)
				{
					return;
				}
				_seqNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get
			{
				if (_isReversed == null)
				{
					_isReversed = (CBool) CR2WTypeManager.Create("Bool", "isReversed", cr2w, this);
				}
				return _isReversed;
			}
			set
			{
				if (_isReversed == value)
				{
					return;
				}
				_isReversed = value;
				PropertySet(this);
			}
		}

		public worldTrafficLaneUID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
