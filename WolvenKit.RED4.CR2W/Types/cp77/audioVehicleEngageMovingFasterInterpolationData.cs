using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleEngageMovingFasterInterpolationData : CVariable
	{
		private CEnum<audioESoundCurveType> _enterCurveType;
		private CFloat _enterCurveTime;
		private CEnum<audioESoundCurveType> _exitCurveType;
		private CFloat _exitCurveTime;

		[Ordinal(0)] 
		[RED("enterCurveType")] 
		public CEnum<audioESoundCurveType> EnterCurveType
		{
			get => GetProperty(ref _enterCurveType);
			set => SetProperty(ref _enterCurveType, value);
		}

		[Ordinal(1)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get => GetProperty(ref _enterCurveTime);
			set => SetProperty(ref _enterCurveTime, value);
		}

		[Ordinal(2)] 
		[RED("exitCurveType")] 
		public CEnum<audioESoundCurveType> ExitCurveType
		{
			get => GetProperty(ref _exitCurveType);
			set => SetProperty(ref _exitCurveType, value);
		}

		[Ordinal(3)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get => GetProperty(ref _exitCurveTime);
			set => SetProperty(ref _exitCurveTime, value);
		}

		public audioVehicleEngageMovingFasterInterpolationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
