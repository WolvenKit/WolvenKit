using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetWeightEntry : CVariable
	{
		private CName _targetName;
		private CName _regionName;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetProperty(ref _targetName);
			set => SetProperty(ref _targetName, value);
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetProperty(ref _regionName);
			set => SetProperty(ref _regionName, value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public entMorphTargetWeightEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
