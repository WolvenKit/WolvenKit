using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotGroup : IScriptable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<vehicleCinematicCameraShotStartCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotStartCondition>>>();
			set => SetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotStartCondition>>>(value);
		}

		[Ordinal(2)] 
		[RED("shots")] 
		public CArray<vehicleCinematicCameraShot> Shots
		{
			get => GetPropertyValue<CArray<vehicleCinematicCameraShot>>();
			set => SetPropertyValue<CArray<vehicleCinematicCameraShot>>(value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleCinematicCameraShotGroup()
		{
			Conditions = new();
			Shots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
