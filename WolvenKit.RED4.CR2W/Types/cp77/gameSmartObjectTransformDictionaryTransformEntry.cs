using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformDictionaryTransformEntry : CVariable
	{
		private Transform _transform;
		private CUInt32 _usage;
		private CUInt16 _id;

		[Ordinal(0)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CUInt32 Usage
		{
			get => GetProperty(ref _usage);
			set => SetProperty(ref _usage, value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public gameSmartObjectTransformDictionaryTransformEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
