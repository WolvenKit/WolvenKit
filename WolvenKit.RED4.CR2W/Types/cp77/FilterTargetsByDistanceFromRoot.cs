using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterTargetsByDistanceFromRoot : gameEffectObjectSingleFilter_Scripted
	{
		private CFloat _rootOffset_Z;
		private CFloat _tollerance;

		[Ordinal(0)] 
		[RED("rootOffset_Z")] 
		public CFloat RootOffset_Z
		{
			get => GetProperty(ref _rootOffset_Z);
			set => SetProperty(ref _rootOffset_Z, value);
		}

		[Ordinal(1)] 
		[RED("tollerance")] 
		public CFloat Tollerance
		{
			get => GetProperty(ref _tollerance);
			set => SetProperty(ref _tollerance, value);
		}

		public FilterTargetsByDistanceFromRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
