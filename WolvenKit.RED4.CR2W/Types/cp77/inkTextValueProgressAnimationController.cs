using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextValueProgressAnimationController : inkTextAnimationController
	{
		private CFloat _baseValue;
		private CFloat _targetValue;
		private CInt32 _numbersAfterDot;
		private CFloat _stepValue;
		private CString _suffix;

		[Ordinal(8)] 
		[RED("baseValue")] 
		public CFloat BaseValue
		{
			get
			{
				if (_baseValue == null)
				{
					_baseValue = (CFloat) CR2WTypeManager.Create("Float", "baseValue", cr2w, this);
				}
				return _baseValue;
			}
			set
			{
				if (_baseValue == value)
				{
					return;
				}
				_baseValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetValue")] 
		public CFloat TargetValue
		{
			get
			{
				if (_targetValue == null)
				{
					_targetValue = (CFloat) CR2WTypeManager.Create("Float", "targetValue", cr2w, this);
				}
				return _targetValue;
			}
			set
			{
				if (_targetValue == value)
				{
					return;
				}
				_targetValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("numbersAfterDot")] 
		public CInt32 NumbersAfterDot
		{
			get
			{
				if (_numbersAfterDot == null)
				{
					_numbersAfterDot = (CInt32) CR2WTypeManager.Create("Int32", "numbersAfterDot", cr2w, this);
				}
				return _numbersAfterDot;
			}
			set
			{
				if (_numbersAfterDot == value)
				{
					return;
				}
				_numbersAfterDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("stepValue")] 
		public CFloat StepValue
		{
			get
			{
				if (_stepValue == null)
				{
					_stepValue = (CFloat) CR2WTypeManager.Create("Float", "stepValue", cr2w, this);
				}
				return _stepValue;
			}
			set
			{
				if (_stepValue == value)
				{
					return;
				}
				_stepValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("suffix")] 
		public CString Suffix
		{
			get
			{
				if (_suffix == null)
				{
					_suffix = (CString) CR2WTypeManager.Create("String", "suffix", cr2w, this);
				}
				return _suffix;
			}
			set
			{
				if (_suffix == value)
				{
					return;
				}
				_suffix = value;
				PropertySet(this);
			}
		}

		public inkTextValueProgressAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
