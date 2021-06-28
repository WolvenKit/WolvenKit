using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayAnimEventData : CVariable
	{
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CFloat _clipFront;
		private CFloat _stretch;
		private CFloat _weight;
		private CName _bodyPartMask;

		[Ordinal(0)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetProperty(ref _blendIn);
			set => SetProperty(ref _blendIn, value);
		}

		[Ordinal(1)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetProperty(ref _blendOut);
			set => SetProperty(ref _blendOut, value);
		}

		[Ordinal(2)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetProperty(ref _clipFront);
			set => SetProperty(ref _clipFront, value);
		}

		[Ordinal(3)] 
		[RED("stretch")] 
		public CFloat Stretch
		{
			get => GetProperty(ref _stretch);
			set => SetProperty(ref _stretch, value);
		}

		[Ordinal(4)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(5)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get => GetProperty(ref _bodyPartMask);
			set => SetProperty(ref _bodyPartMask, value);
		}

		public scnPlayAnimEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
