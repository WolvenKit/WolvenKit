using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraTagLimitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("object")] 
		public CWeakHandle<SurveillanceCamera> Object
		{
			get => GetPropertyValue<CWeakHandle<SurveillanceCamera>>();
			set => SetPropertyValue<CWeakHandle<SurveillanceCamera>>(value);
		}

		public CameraTagLimitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
