using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextConsumableParameters : CVariable
	{
		private CStatic<gamestateMachineConsumableParameterBool> _boolParameters;
		private CStatic<gamestateMachineConsumableParameterInt> _intParameters;
		private CStatic<gamestateMachineConsumableParameterFloat> _floatParameters;
		private CStatic<gamestateMachineConsumableParameterDouble> _doubleParameters;
		private CStatic<gamestateMachineConsumableParameterVector> _vectorParameters;
		private CStatic<gamestateMachineConsumableParameterCName> _cNameParameters;
		private CStatic<gamestateMachineConsumableParameterIScriptable> _iScriptableParameters;
		private CStatic<gamestateMachineConsumableParameterWeakIScriptable> _weakIScriptableParameters;
		private CStatic<gamestateMachineConsumableParameterTweakDBID> _tweakDBIDParameters;

		[Ordinal(0)] 
		[RED("boolParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterBool> BoolParameters
		{
			get => GetProperty(ref _boolParameters);
			set => SetProperty(ref _boolParameters, value);
		}

		[Ordinal(1)] 
		[RED("intParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterInt> IntParameters
		{
			get => GetProperty(ref _intParameters);
			set => SetProperty(ref _intParameters, value);
		}

		[Ordinal(2)] 
		[RED("floatParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterFloat> FloatParameters
		{
			get => GetProperty(ref _floatParameters);
			set => SetProperty(ref _floatParameters, value);
		}

		[Ordinal(3)] 
		[RED("doubleParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterDouble> DoubleParameters
		{
			get => GetProperty(ref _doubleParameters);
			set => SetProperty(ref _doubleParameters, value);
		}

		[Ordinal(4)] 
		[RED("vectorParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterVector> VectorParameters
		{
			get => GetProperty(ref _vectorParameters);
			set => SetProperty(ref _vectorParameters, value);
		}

		[Ordinal(5)] 
		[RED("CNameParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterCName> CNameParameters
		{
			get => GetProperty(ref _cNameParameters);
			set => SetProperty(ref _cNameParameters, value);
		}

		[Ordinal(6)] 
		[RED("IScriptableParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterIScriptable> IScriptableParameters
		{
			get => GetProperty(ref _iScriptableParameters);
			set => SetProperty(ref _iScriptableParameters, value);
		}

		[Ordinal(7)] 
		[RED("weakIScriptableParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters
		{
			get => GetProperty(ref _weakIScriptableParameters);
			set => SetProperty(ref _weakIScriptableParameters, value);
		}

		[Ordinal(8)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters
		{
			get => GetProperty(ref _tweakDBIDParameters);
			set => SetProperty(ref _tweakDBIDParameters, value);
		}

		public gamestateMachineStateContextConsumableParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
