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
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public AIParametrizedResourceReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
