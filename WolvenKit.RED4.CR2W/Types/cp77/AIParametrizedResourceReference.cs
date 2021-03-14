using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIParametrizedResourceReference : AIResourceReference
	{
		private LibTreeParametersForwarder _overrides;

		[Ordinal(2)] 
		[RED("overrides")] 
		public LibTreeParametersForwarder Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (LibTreeParametersForwarder) CR2WTypeManager.Create("LibTreeParametersForwarder", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public AIParametrizedResourceReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
