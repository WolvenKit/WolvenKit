using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSetParameterOnEmitter : gameaudioeventsEmitterEvent
	{
		private CName _paramName;
		private CFloat _paramValue;

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
		[RED("paramValue")] 
		public CFloat ParamValue
		{
			get
			{
				if (_paramValue == null)
				{
					_paramValue = (CFloat) CR2WTypeManager.Create("Float", "paramValue", cr2w, this);
				}
				return _paramValue;
			}
			set
			{
				if (_paramValue == value)
				{
					return;
				}
				_paramValue = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsSetParameterOnEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
