using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimTrackParameter : CVariable
	{
		private CName _animTrackName;
		private CName _parameterName;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("animTrackName")] 
		public CName AnimTrackName
		{
			get
			{
				if (_animTrackName == null)
				{
					_animTrackName = (CName) CR2WTypeManager.Create("CName", "animTrackName", cr2w, this);
				}
				return _animTrackName;
			}
			set
			{
				if (_animTrackName == value)
				{
					return;
				}
				_animTrackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public entAnimTrackParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
