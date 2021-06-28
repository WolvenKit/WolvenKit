using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entExternalComponent : entIComponent
	{
		private CName _externalComponentName;

		[Ordinal(3)] 
		[RED("externalComponentName")] 
		public CName ExternalComponentName
		{
			get => GetProperty(ref _externalComponentName);
			set => SetProperty(ref _externalComponentName, value);
		}

		public entExternalComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
