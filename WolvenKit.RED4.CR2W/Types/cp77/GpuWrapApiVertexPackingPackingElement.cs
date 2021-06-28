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
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CEnum<GpuWrapApiVertexPackingePackingUsage> Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(2)] 
		[RED("usageIndex")] 
		public CUInt8 UsageIndex
		{
			get => GetProperty(ref _usageIndex);
			set => SetProperty(ref _usageIndex, value);
		}

		[Ordinal(3)] 
		[RED("streamIndex")] 
		public CUInt8 StreamIndex
		{
			get => GetProperty(ref _streamIndex);
			set => SetProperty(ref _streamIndex, value);
		}

		[Ordinal(4)] 
		[RED("streamType")] 
		public CEnum<GpuWrapApiVertexPackingEStreamType> StreamType
		{
			get => GetProperty(ref _streamType);
			set => SetProperty(ref _streamType, value);
		}

		public GpuWrapApiVertexPackingPackingElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
