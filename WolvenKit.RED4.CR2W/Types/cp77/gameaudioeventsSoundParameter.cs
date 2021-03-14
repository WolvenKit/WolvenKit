using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundParameter : redEvent
	{
		private CName _parameterName;
		private CFloat _parameterValue;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get
			{
				if (_parameterName == null)
				{
					_parameterName = (CName) CR2WTypeManager.Create("CName", "parameterName", cr2w, this);
				}
				return _parameterName;
			}
			set
			{
				if (_parameterName == value)
				{
					return;
				}
				_parameterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parameterValue")] 
		public CFloat ParameterValue
		{
			get
			{
				if (_parameterValue == null)
				{
					_parameterValue = (CFloat) CR2WTypeManager.Create("Float", "parameterValue", cr2w, this);
				}
				return _parameterValue;
			}
			set
			{
				if (_parameterValue == value)
				{
					return;
				}
				_parameterValue = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsSoundParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
