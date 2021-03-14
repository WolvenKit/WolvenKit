using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrefetchStreaming_NodeTypeV2 : questIWorldDataManagerNodeType
	{
		private NodeRef _prefetchPositionRef;
		private CBool _useStreamingOcclusion;
		private CFloat _maxDistance;

		[Ordinal(0)] 
		[RED("prefetchPositionRef")] 
		public NodeRef PrefetchPositionRef
		{
			get
			{
				if (_prefetchPositionRef == null)
				{
					_prefetchPositionRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefetchPositionRef", cr2w, this);
				}
				return _prefetchPositionRef;
			}
			set
			{
				if (_prefetchPositionRef == value)
				{
					return;
				}
				_prefetchPositionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useStreamingOcclusion")] 
		public CBool UseStreamingOcclusion
		{
			get
			{
				if (_useStreamingOcclusion == null)
				{
					_useStreamingOcclusion = (CBool) CR2WTypeManager.Create("Bool", "useStreamingOcclusion", cr2w, this);
				}
				return _useStreamingOcclusion;
			}
			set
			{
				if (_useStreamingOcclusion == value)
				{
					return;
				}
				_useStreamingOcclusion = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
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

		public questPrefetchStreaming_NodeTypeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
