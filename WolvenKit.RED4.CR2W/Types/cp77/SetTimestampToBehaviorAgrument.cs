using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTimestampToBehaviorAgrument : AIbehaviortaskScript
	{
		private CName _timestampArgument;

		[Ordinal(0)] 
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

		public SetTimestampToBehaviorAgrument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
