using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateContextParameters : RedBaseClass
	{
		private CStatic<gamestateMachineActionParameterBool> _boolParameters;
		private CStatic<gamestateMachineActionParameterInt> _intParameters;
		private CStatic<gamestateMachineActionParameterFloat> _floatParameters;
		private CStatic<gamestateMachineActionParameterDouble> _doubleParameters;
		private CStatic<gamestateMachineActionParameterVector> _vectorParameters;
		private CStatic<gamestateMachineActionParameterCName> _cNameParameters;
		private CStatic<gamestateMachineActionParameterIScriptable> _iScriptableParameters;
		private CStatic<gamestateMachineActionParameterTweakDBID> _tweakDBIDParameters;

		[Ordinal(0)] 
		[RED("boolParameters", 128)] 
		public CStatic<gamestateMachineActionParameterBool> BoolParameters
		{
			get => GetProperty(ref _boolParameters);
			set => SetProperty(ref _boolParameters, value);
		}

		[Ordinal(1)] 
		[RED("intParameters", 128)] 
		public CStatic<gamestateMachineActionParameterInt> IntParameters
		{
			get => GetProperty(ref _intParameters);
			set => SetProperty(ref _intParameters, value);
		}

		[Ordinal(2)] 
		[RED("floatParameters", 128)] 
		public CStatic<gamestateMachineActionParameterFloat> FloatParameters
		{
			get => GetProperty(ref _floatParameters);
			set => SetProperty(ref _floatParameters, value);
		}

		[Ordinal(3)] 
		[RED("doubleParameters", 128)] 
		public CStatic<gamestateMachineActionParameterDouble> DoubleParameters
		{
			get => GetProperty(ref _doubleParameters);
			set => SetProperty(ref _doubleParameters, value);
		}

		[Ordinal(4)] 
		[RED("vectorParameters", 128)] 
		public CStatic<gamestateMachineActionParameterVector> VectorParameters
		{
			get => GetProperty(ref _vectorParameters);
			set => SetProperty(ref _vectorParameters, value);
		}

		[Ordinal(5)] 
		[RED("CNameParameters", 128)] 
		public CStatic<gamestateMachineActionParameterCName> CNameParameters
		{
			get => GetProperty(ref _cNameParameters);
			set => SetProperty(ref _cNameParameters, value);
		}

		[Ordinal(6)] 
		[RED("IScriptableParameters", 128)] 
		public CStatic<gamestateMachineActionParameterIScriptable> IScriptableParameters
		{
			get => GetProperty(ref _iScriptableParameters);
			set => SetProperty(ref _iScriptableParameters, value);
		}

		[Ordinal(7)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineActionParameterTweakDBID> TweakDBIDParameters
		{
			get => GetProperty(ref _tweakDBIDParameters);
			set => SetProperty(ref _tweakDBIDParameters, value);
		}
	}
}
