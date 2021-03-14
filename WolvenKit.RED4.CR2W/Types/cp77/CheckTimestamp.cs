using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckTimestamp : AIbehaviorconditionScript
	{
		private CFloat _validationTime;
		private CName _timestampArgument;

		[Ordinal(0)] 
		[RED("validationTime")] 
		public CFloat ValidationTime
		{
			get
			{
				if (_validationTime == null)
				{
					_validationTime = (CFloat) CR2WTypeManager.Create("Float", "validationTime", cr2w, this);
				}
				return _validationTime;
			}
			set
			{
				if (_validationTime == value)
				{
					return;
				}
				_validationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get
			{
				if (_timestampArgument == null)
				{
					_timestampArgument = (CName) CR2WTypeManager.Create("CName", "timestampArgument", cr2w, this);
				}
				return _timestampArgument;
			}
			set
			{
				if (_timestampArgument == value)
				{
					return;
				}
				_timestampArgument = value;
				PropertySet(this);
			}
		}

		public CheckTimestamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
