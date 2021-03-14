using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableContainer : ISerializable
	{
		private CArray<CHandle<animAnimVariableBool>> _boolVariables;
		private CArray<CHandle<animAnimVariableInt>> _intVariables;
		private CArray<CHandle<animAnimVariableFloat>> _floatVariables;
		private CArray<CHandle<animAnimVariableVector>> _vectorVariables;
		private CArray<CHandle<animAnimVariableQuaternion>> _quaternionVariables;
		private CArray<CHandle<animAnimVariableTransform>> _transformVariables;

		[Ordinal(0)] 
		[RED("boolVariables")] 
		public CArray<CHandle<animAnimVariableBool>> BoolVariables
		{
			get
			{
				if (_boolVariables == null)
				{
					_boolVariables = (CArray<CHandle<animAnimVariableBool>>) CR2WTypeManager.Create("array:handle:animAnimVariableBool", "boolVariables", cr2w, this);
				}
				return _boolVariables;
			}
			set
			{
				if (_boolVariables == value)
				{
					return;
				}
				_boolVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("intVariables")] 
		public CArray<CHandle<animAnimVariableInt>> IntVariables
		{
			get
			{
				if (_intVariables == null)
				{
					_intVariables = (CArray<CHandle<animAnimVariableInt>>) CR2WTypeManager.Create("array:handle:animAnimVariableInt", "intVariables", cr2w, this);
				}
				return _intVariables;
			}
			set
			{
				if (_intVariables == value)
				{
					return;
				}
				_intVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("floatVariables")] 
		public CArray<CHandle<animAnimVariableFloat>> FloatVariables
		{
			get
			{
				if (_floatVariables == null)
				{
					_floatVariables = (CArray<CHandle<animAnimVariableFloat>>) CR2WTypeManager.Create("array:handle:animAnimVariableFloat", "floatVariables", cr2w, this);
				}
				return _floatVariables;
			}
			set
			{
				if (_floatVariables == value)
				{
					return;
				}
				_floatVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vectorVariables")] 
		public CArray<CHandle<animAnimVariableVector>> VectorVariables
		{
			get
			{
				if (_vectorVariables == null)
				{
					_vectorVariables = (CArray<CHandle<animAnimVariableVector>>) CR2WTypeManager.Create("array:handle:animAnimVariableVector", "vectorVariables", cr2w, this);
				}
				return _vectorVariables;
			}
			set
			{
				if (_vectorVariables == value)
				{
					return;
				}
				_vectorVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quaternionVariables")] 
		public CArray<CHandle<animAnimVariableQuaternion>> QuaternionVariables
		{
			get
			{
				if (_quaternionVariables == null)
				{
					_quaternionVariables = (CArray<CHandle<animAnimVariableQuaternion>>) CR2WTypeManager.Create("array:handle:animAnimVariableQuaternion", "quaternionVariables", cr2w, this);
				}
				return _quaternionVariables;
			}
			set
			{
				if (_quaternionVariables == value)
				{
					return;
				}
				_quaternionVariables = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("transformVariables")] 
		public CArray<CHandle<animAnimVariableTransform>> TransformVariables
		{
			get
			{
				if (_transformVariables == null)
				{
					_transformVariables = (CArray<CHandle<animAnimVariableTransform>>) CR2WTypeManager.Create("array:handle:animAnimVariableTransform", "transformVariables", cr2w, this);
				}
				return _transformVariables;
			}
			set
			{
				if (_transformVariables == value)
				{
					return;
				}
				_transformVariables = value;
				PropertySet(this);
			}
		}

		public animAnimVariableContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
