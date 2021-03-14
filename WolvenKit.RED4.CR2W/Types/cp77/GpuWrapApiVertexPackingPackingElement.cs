using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GpuWrapApiVertexPackingPackingElement : CVariable
	{
		private CEnum<GpuWrapApiVertexPackingePackingType> _type;
		private CEnum<GpuWrapApiVertexPackingePackingUsage> _usage;
		private CUInt8 _usageIndex;
		private CUInt8 _streamIndex;
		private CEnum<GpuWrapApiVertexPackingEStreamType> _streamType;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GpuWrapApiVertexPackingePackingType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<GpuWrapApiVertexPackingePackingType>) CR2WTypeManager.Create("GpuWrapApiVertexPackingePackingType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CEnum<GpuWrapApiVertexPackingePackingUsage> Usage
		{
			get
			{
				if (_usage == null)
				{
					_usage = (CEnum<GpuWrapApiVertexPackingePackingUsage>) CR2WTypeManager.Create("GpuWrapApiVertexPackingePackingUsage", "usage", cr2w, this);
				}
				return _usage;
			}
			set
			{
				if (_usage == value)
				{
					return;
				}
				_usage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("usageIndex")] 
		public CUInt8 UsageIndex
		{
			get
			{
				if (_usageIndex == null)
				{
					_usageIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "usageIndex", cr2w, this);
				}
				return _usageIndex;
			}
			set
			{
				if (_usageIndex == value)
				{
					return;
				}
				_usageIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("streamIndex")] 
		public CUInt8 StreamIndex
		{
			get
			{
				if (_streamIndex == null)
				{
					_streamIndex = (CUInt8) CR2WTypeManager.Create("Uint8", "streamIndex", cr2w, this);
				}
				return _streamIndex;
			}
			set
			{
				if (_streamIndex == value)
				{
					return;
				}
				_streamIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("streamType")] 
		public CEnum<GpuWrapApiVertexPackingEStreamType> StreamType
		{
			get
			{
				if (_streamType == null)
				{
					_streamType = (CEnum<GpuWrapApiVertexPackingEStreamType>) CR2WTypeManager.Create("GpuWrapApiVertexPackingEStreamType", "streamType", cr2w, this);
				}
				return _streamType;
			}
			set
			{
				if (_streamType == value)
				{
					return;
				}
				_streamType = value;
				PropertySet(this);
			}
		}

		public GpuWrapApiVertexPackingPackingElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
