using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questValueDistance : questIDistance
	{
		private CFloat _distanceValue;

		[Ordinal(0)] 
		[RED("distanceValue")] 
		public CFloat DistanceValue
		{
			get => GetProperty(ref _distanceValue);
			set => SetProperty(ref _distanceValue, value);
		}

		public questValueDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
