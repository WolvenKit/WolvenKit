using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompiledCrowdData : ISerializable
	{
		private CArray<gameCrowdTrafficDataPackage> _trafficDataPackages;

		[Ordinal(0)] 
		[RED("trafficDataPackages")] 
		public CArray<gameCrowdTrafficDataPackage> TrafficDataPackages
		{
			get => GetProperty(ref _trafficDataPackages);
			set => SetProperty(ref _trafficDataPackages, value);
		}

		public gameCompiledCrowdData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
