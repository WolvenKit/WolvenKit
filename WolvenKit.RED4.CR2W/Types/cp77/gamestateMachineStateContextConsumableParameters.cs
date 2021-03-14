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
			get
			{
				if (_boolParameters == null)
				{
					_boolParameters = (CStatic<gamestateMachineConsumableParameterBool>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterBool", "boolParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterInt> IntParameters
		{
			get
			{
				if (_intParameters == null)
				{
					_intParameters = (CStatic<gamestateMachineConsumableParameterInt>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterInt", "intParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterFloat> FloatParameters
		{
			get
			{
				if (_floatParameters == null)
				{
					_floatParameters = (CStatic<gamestateMachineConsumableParameterFloat>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterFloat", "floatParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterDouble> DoubleParameters
		{
			get
			{
				if (_doubleParameters == null)
				{
					_doubleParameters = (CStatic<gamestateMachineConsumableParameterDouble>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterDouble", "doubleParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterVector> VectorParameters
		{
			get
			{
				if (_vectorParameters == null)
				{
					_vectorParameters = (CStatic<gamestateMachineConsumableParameterVector>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterVector", "vectorParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterCName> CNameParameters
		{
			get
			{
				if (_cNameParameters == null)
				{
					_cNameParameters = (CStatic<gamestateMachineConsumableParameterCName>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterCName", "CNameParameters", cr2w, this);
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
		public CStatic<gamestateMachineConsumableParameterIScriptable> IScriptableParameters
		{
			get
			{
				if (_iScriptableParameters == null)
				{
					_iScriptableParameters = (CStatic<gamestateMachineConsumableParameterIScriptable>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterIScriptable", "IScriptableParameters", cr2w, this);
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
		[RED("weakIScriptableParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters
		{
			get
			{
				if (_weakIScriptableParameters == null)
				{
					_weakIScriptableParameters = (CStatic<gamestateMachineConsumableParameterWeakIScriptable>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterWeakIScriptable", "weakIScriptableParameters", cr2w, this);
				}
				return _weakIScriptableParameters;
			}
			set
			{
				if (_weakIScriptableParameters == value)
				{
					return;
				}
				_weakIScriptableParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tweakDBIDParameters", 128)] 
		public CStatic<gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters
		{
			get
			{
				if (_tweakDBIDParameters == null)
				{
					_tweakDBIDParameters = (CStatic<gamestateMachineConsumableParameterTweakDBID>) CR2WTypeManager.Create("static:128,gamestateMachineConsumableParameterTweakDBID", "tweakDBIDParameters", cr2w, this);
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

		public gamestateMachineStateContextConsumableParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
