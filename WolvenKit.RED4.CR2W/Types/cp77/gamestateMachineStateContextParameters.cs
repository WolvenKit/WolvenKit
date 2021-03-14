using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextParameters : CVariable
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
			get
			{
				if (_boolParameters == null)
				{
					_boolParameters = (CStatic<gamestateMachineActionParameterBool>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterBool", "boolParameters", cr2w, this);
				}
				return _boolParameters;
			}
			set
			{
				if (_boolParameters == value)
				{
					return;
				}
				_boolParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("intParameters", 128)] 
		public CStatic<gamestateMachineActionParameterInt> IntParameters
		{
			get
			{
				if (_intParameters == null)
				{
					_intParameters = (CStatic<gamestateMachineActionParameterInt>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterInt", "intParameters", cr2w, this);
				}
				return _intParameters;
			}
			set
			{
				if (_intParameters == value)
				{
					return;
				}
				_intParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("floatParameters", 128)] 
		public CStatic<gamestateMachineActionParameterFloat> FloatParameters
		{
			get
			{
				if (_floatParameters == null)
				{
					_floatParameters = (CStatic<gamestateMachineActionParameterFloat>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterFloat", "floatParameters", cr2w, this);
				}
				return _floatParameters;
			}
			set
			{
				if (_floatParameters == value)
				{
					return;
				}
				_floatParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doubleParameters", 128)] 
		public CStatic<gamestateMachineActionParameterDouble> DoubleParameters
		{
			get
			{
				if (_doubleParameters == null)
				{
					_doubleParameters = (CStatic<gamestateMachineActionParameterDouble>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterDouble", "doubleParameters", cr2w, this);
				}
				return _doubleParameters;
			}
			set
			{
				if (_doubleParameters == value)
				{
					return;
				}
				_doubleParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vectorParameters", 128)] 
		public CStatic<gamestateMachineActionParameterVector> VectorParameters
		{
			get
			{
				if (_vectorParameters == null)
				{
					_vectorParameters = (CStatic<gamestateMachineActionParameterVector>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterVector", "vectorParameters", cr2w, this);
				}
				return _vectorParameters;
			}
			set
			{
				if (_vectorParameters == value)
				{
					return;
				}
				_vectorParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("CNameParameters", 128)] 
		public CStatic<gamestateMachineActionParameterCName> CNameParameters
		{
			get
			{
				if (_cNameParameters == null)
				{
					_cNameParameters = (CStatic<gamestateMachineActionParameterCName>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterCName", "CNameParameters", cr2w, this);
				}
				return _cNameParameters;
			}
			set
			{
				if (_cNameParameters == value)
				{
					return;
				}
				_cNameParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IScriptableParameters", 128)] 
		public CStatic<gamestateMachineActionParameterIScriptable> IScriptableParameters
		{
			get
			{
				if (_iScriptableParameters == null)
				{
					_iScriptableParameters = (CStatic<gamestateMachineActionParameterIScriptable>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterIScriptable", "IScriptableParameters", cr2w, this);
				}
				return _iScriptableParameters;
			}
			set
			{
				if (_iScriptableParameters == value)
				{
					return;
				}
				_iScriptableParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineActionParameterTweakDBID> TweakDBIDParameters
		{
			get
			{
				if (_tweakDBIDParameters == null)
				{
					_tweakDBIDParameters = (CStatic<gamestateMachineActionParameterTweakDBID>) CR2WTypeManager.Create("static:128,gamestateMachineActionParameterTweakDBID", "tweakDBIDParameters", cr2w, this);
				}
				return _tweakDBIDParameters;
			}
			set
			{
				if (_tweakDBIDParameters == value)
				{
					return;
				}
				_tweakDBIDParameters = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateContextParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
