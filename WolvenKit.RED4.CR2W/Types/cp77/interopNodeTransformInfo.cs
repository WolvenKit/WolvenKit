using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopNodeTransformInfo : CVariable
	{
		private interopStringWithID _id;
		private interopTransformInfo _transformInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public interopStringWithID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("transformInfo")] 
		public interopTransformInfo TransformInfo
		{
			get => GetProperty(ref _transformInfo);
			set => SetProperty(ref _transformInfo, value);
		}

		public interopNodeTransformInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
