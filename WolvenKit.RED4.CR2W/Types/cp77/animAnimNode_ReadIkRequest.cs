using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		private CName _ikChain;
		private animTransformIndex _outTransform;

		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetProperty(ref _ikChain);
			set => SetProperty(ref _ikChain, value);
		}

		[Ordinal(13)] 
		[RED("outTransform")] 
		public animTransformIndex OutTransform
		{
			get => GetProperty(ref _outTransform);
			set => SetProperty(ref _outTransform, value);
		}

		public animAnimNode_ReadIkRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
