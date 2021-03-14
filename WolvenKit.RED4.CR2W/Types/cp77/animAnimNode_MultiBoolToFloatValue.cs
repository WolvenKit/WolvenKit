using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		private CBool _allMustBeTrue;
		private CFloat _onTrue;
		private CFloat _onFalse;
		private CArray<animAnimMultiBoolToFloatEntry> _inputsData;

		[Ordinal(11)] 
		[RED("allMustBeTrue")] 
		public CBool AllMustBeTrue
		{
			get
			{
				if (_allMustBeTrue == null)
				{
					_allMustBeTrue = (CBool) CR2WTypeManager.Create("Bool", "allMustBeTrue", cr2w, this);
				}
				return _allMustBeTrue;
			}
			set
			{
				if (_allMustBeTrue == value)
				{
					return;
				}
				_allMustBeTrue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("onTrue")] 
		public CFloat OnTrue
		{
			get
			{
				if (_onTrue == null)
				{
					_onTrue = (CFloat) CR2WTypeManager.Create("Float", "onTrue", cr2w, this);
				}
				return _onTrue;
			}
			set
			{
				if (_onTrue == value)
				{
					return;
				}
				_onTrue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("onFalse")] 
		public CFloat OnFalse
		{
			get
			{
				if (_onFalse == null)
				{
					_onFalse = (CFloat) CR2WTypeManager.Create("Float", "onFalse", cr2w, this);
				}
				return _onFalse;
			}
			set
			{
				if (_onFalse == value)
				{
					return;
				}
				_onFalse = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inputsData")] 
		public CArray<animAnimMultiBoolToFloatEntry> InputsData
		{
			get
			{
				if (_inputsData == null)
				{
					_inputsData = (CArray<animAnimMultiBoolToFloatEntry>) CR2WTypeManager.Create("array:animAnimMultiBoolToFloatEntry", "inputsData", cr2w, this);
				}
				return _inputsData;
			}
			set
			{
				if (_inputsData == value)
				{
					return;
				}
				_inputsData = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MultiBoolToFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
