using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendByMaskDynamic : animAnimNode_Base
	{
		private animPoseLink _base;
		private animPoseLink _blend;
		private animIntLink _mask;
		private animFloatLink _weight;
		private CArray<CName> _masks;
		private CHandle<animISyncMethod> _syncMethod;

		[Ordinal(11)] 
		[RED("base")] 
		public animPoseLink Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}

		[Ordinal(12)] 
		[RED("blend")] 
		public animPoseLink Blend
		{
			get => GetProperty(ref _blend);
			set => SetProperty(ref _blend, value);
		}

		[Ordinal(13)] 
		[RED("mask")] 
		public animIntLink Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(15)] 
		[RED("masks")] 
		public CArray<CName> Masks
		{
			get => GetProperty(ref _masks);
			set => SetProperty(ref _masks, value);
		}

		[Ordinal(16)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		public animAnimNode_BlendByMaskDynamic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
