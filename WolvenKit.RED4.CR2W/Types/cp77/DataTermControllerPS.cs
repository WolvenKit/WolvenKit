using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private CEnum<EFastTravelTriggerType> _triggerType;
		private CEnum<EFastTravelDeviceType> _fastTravelDeviceType;

		[Ordinal(104)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetProperty(ref _linkedFastTravelPoint);
			set => SetProperty(ref _linkedFastTravelPoint, value);
		}

		[Ordinal(105)] 
		[RED("triggerType")] 
		public CEnum<EFastTravelTriggerType> TriggerType
		{
			get => GetProperty(ref _triggerType);
			set => SetProperty(ref _triggerType, value);
		}

		[Ordinal(106)] 
		[RED("fastTravelDeviceType")] 
		public CEnum<EFastTravelDeviceType> FastTravelDeviceType
		{
			get => GetProperty(ref _fastTravelDeviceType);
			set => SetProperty(ref _fastTravelDeviceType, value);
		}

		public DataTermControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
