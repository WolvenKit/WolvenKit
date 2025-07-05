using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateContextParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boolParameters", 128)] 
		public CStatic<gamestateMachineActionParameterBool> BoolParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterBool>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterBool>>(value);
		}

		[Ordinal(1)] 
		[RED("intParameters", 128)] 
		public CStatic<gamestateMachineActionParameterInt> IntParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterInt>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterInt>>(value);
		}

		[Ordinal(2)] 
		[RED("floatParameters", 128)] 
		public CStatic<gamestateMachineActionParameterFloat> FloatParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterFloat>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("doubleParameters", 128)] 
		public CStatic<gamestateMachineActionParameterDouble> DoubleParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterDouble>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterDouble>>(value);
		}

		[Ordinal(4)] 
		[RED("vectorParameters", 128)] 
		public CStatic<gamestateMachineActionParameterVector> VectorParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterVector>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterVector>>(value);
		}

		[Ordinal(5)] 
		[RED("CNameParameters", 128)] 
		public CStatic<gamestateMachineActionParameterCName> CNameParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterCName>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterCName>>(value);
		}

		[Ordinal(6)] 
		[RED("IScriptableParameters", 128)] 
		public CStatic<gamestateMachineActionParameterIScriptable> IScriptableParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterIScriptable>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterIScriptable>>(value);
		}

		[Ordinal(7)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineActionParameterTweakDBID> TweakDBIDParameters
		{
			get => GetPropertyValue<CStatic<gamestateMachineActionParameterTweakDBID>>();
			set => SetPropertyValue<CStatic<gamestateMachineActionParameterTweakDBID>>(value);
		}

		public gamestateMachineStateContextParameters()
		{
			BoolParameters = new(0);
			IntParameters = new(0);
			FloatParameters = new(0);
			DoubleParameters = new(0);
			VectorParameters = new(0);
			CNameParameters = new(0);
			IScriptableParameters = new(0);
			TweakDBIDParameters = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
