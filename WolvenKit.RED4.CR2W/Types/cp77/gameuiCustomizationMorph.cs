using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationMorph : gameuiCensorshipInfo
	{
		private CName _regionName;
		private CName _targetName;

		[Ordinal(2)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetProperty(ref _regionName);
			set => SetProperty(ref _regionName, value);
		}

		[Ordinal(3)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetProperty(ref _targetName);
			set => SetProperty(ref _targetName, value);
		}

		public gameuiCustomizationMorph(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
