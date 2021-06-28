using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		private animAdditionalTransformContainer _additionalTransforms;

		[Ordinal(12)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetProperty(ref _additionalTransforms);
			set => SetProperty(ref _additionalTransforms, value);
		}

		public animAnimNode_AdditionalTransform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
