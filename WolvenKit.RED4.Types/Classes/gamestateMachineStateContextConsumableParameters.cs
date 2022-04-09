using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateContextConsumableParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boolParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterBool> BoolParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterBool>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterBool>>(value);
		}

		[Ordinal(1)] 
		[RED("intParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterInt> IntParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterInt>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterInt>>(value);
		}

		[Ordinal(2)] 
		[RED("floatParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterFloat> FloatParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterFloat>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("doubleParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterDouble> DoubleParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterDouble>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterDouble>>(value);
		}

		[Ordinal(4)] 
		[RED("vectorParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterVector> VectorParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterVector>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterVector>>(value);
		}

		[Ordinal(5)] 
		[RED("CNameParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterCName> CNameParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterCName>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterCName>>(value);
		}

		[Ordinal(6)] 
		[RED("IScriptableParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterIScriptable> IScriptableParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterIScriptable>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterIScriptable>>(value);
		}

		[Ordinal(7)] 
		[RED("weakIScriptableParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterWeakIScriptable>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterWeakIScriptable>>(value);
		}

		[Ordinal(8)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineConsumableParameterTweakDBID>>();
			set => SetPropertyValue<CStatic<gamestateMachineConsumableParameterTweakDBID>>(value);
		}

		public gamestateMachineStateContextConsumableParameters()
		{
			BoolParameters = new(0);
			IntParameters = new(0);
			FloatParameters = new(0);
			DoubleParameters = new(0);
			VectorParameters = new(0);
			CNameParameters = new(0);
			IScriptableParameters = new(0);
			WeakIScriptableParameters = new(0);
			TweakDBIDParameters = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
