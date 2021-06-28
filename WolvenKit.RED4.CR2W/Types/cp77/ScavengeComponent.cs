using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScavengeComponent : gameScriptableComponent
	{
		private CArray<wCHandle<gameObject>> _scavengeTargets;

		[Ordinal(5)] 
		[RED("scavengeTargets")] 
		public CArray<wCHandle<gameObject>> ScavengeTargets
		{
			get => GetProperty(ref _scavengeTargets);
			set => SetProperty(ref _scavengeTargets, value);
		}

		public ScavengeComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
