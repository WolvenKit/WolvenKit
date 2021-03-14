using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixParamDescription : CVariable
	{
		private CName _parameter;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get
			{
				if (_parameter == null)
				{
					_parameter = (CName) CR2WTypeManager.Create("CName", "parameter", cr2w, this);
				}
				return _parameter;
			}
			set
			{
				if (_parameter == value)
				{
					return;
				}
				_parameter = value;
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

		public audioMixParamDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
