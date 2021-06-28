using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventExData : CVariable
	{
		private scneventsPlayAnimEventData _basic;
		private CFloat _weight;
		private CName _bodyPartMask;

		[Ordinal(0)] 
		[RED("basic")] 
		public scneventsPlayAnimEventData Basic
		{
			get => GetProperty(ref _basic);
			set => SetProperty(ref _basic, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get => GetProperty(ref _bodyPartMask);
			set => SetProperty(ref _bodyPartMask, value);
		}

		public scneventsPlayAnimEventExData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
