using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimParamSlotsOption : CVariable
	{
		private TweakDBID _slotID;
		private CName _paramName;
		private CEnum<entAnimParamSlotFunction> _function;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get
			{
				if (_paramName == null)
				{
					_paramName = (CName) CR2WTypeManager.Create("CName", "paramName", cr2w, this);
				}
				return _paramName;
			}
			set
			{
				if (_paramName == value)
				{
					return;
				}
				_paramName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("function")] 
		public CEnum<entAnimParamSlotFunction> Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CEnum<entAnimParamSlotFunction>) CR2WTypeManager.Create("entAnimParamSlotFunction", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		public gameAnimParamSlotsOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
