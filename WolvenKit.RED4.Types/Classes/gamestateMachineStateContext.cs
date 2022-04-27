using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshotsContainer Snapshot
		{
			get => GetPropertyValue<gamestateMachineStateSnapshotsContainer>();
			set => SetPropertyValue<gamestateMachineStateSnapshotsContainer>(value);
		}

		[Ordinal(1)] 
		[RED("permanentParameters")] 
		public gamestateMachineStateContextParameters PermanentParameters
		{
			get => GetPropertyValue<gamestateMachineStateContextParameters>();
			set => SetPropertyValue<gamestateMachineStateContextParameters>(value);
		}

		public gamestateMachineStateContext()
		{
			Snapshot = new() { Snapshot = new() };
			PermanentParameters = new() { BoolParameters = new(0), IntParameters = new(0), FloatParameters = new(0), DoubleParameters = new(0), VectorParameters = new(0), CNameParameters = new(0), IScriptableParameters = new(0), TweakDBIDParameters = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
