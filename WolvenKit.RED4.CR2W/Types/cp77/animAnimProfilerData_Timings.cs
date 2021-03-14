using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_Timings : CVariable
	{
		private CName _className;
		private CFloat _avarageExclusiveTimeMS;
		private CFloat _avarageInclusiveTimeMS;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveTimeMS")] 
		public CFloat AvarageExclusiveTimeMS
		{
			get
			{
				if (_avarageExclusiveTimeMS == null)
				{
					_avarageExclusiveTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageExclusiveTimeMS", cr2w, this);
				}
				return _avarageExclusiveTimeMS;
			}
			set
			{
				if (_avarageExclusiveTimeMS == value)
				{
					return;
				}
				_avarageExclusiveTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveTimeMS")] 
		public CFloat AvarageInclusiveTimeMS
		{
			get
			{
				if (_avarageInclusiveTimeMS == null)
				{
					_avarageInclusiveTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageInclusiveTimeMS", cr2w, this);
				}
				return _avarageInclusiveTimeMS;
			}
			set
			{
				if (_avarageInclusiveTimeMS == value)
				{
					return;
				}
				_avarageInclusiveTimeMS = value;
				PropertySet(this);
			}
		}

		public animAnimProfilerData_Timings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
