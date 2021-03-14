using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimWrapperVariableDescription : CVariable
	{
		private CName _variableName;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get
			{
				if (_variableName == null)
				{
					_variableName = (CName) CR2WTypeManager.Create("CName", "variableName", cr2w, this);
				}
				return _variableName;
			}
			set
			{
				if (_variableName == value)
				{
					return;
				}
				_variableName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CFloat) CR2WTypeManager.Create("Float", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public animAnimWrapperVariableDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
