using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questPuppetsEffector> _effector;
		private gameEntityReference _reference;

		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<questPuppetsEffector> Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		[Ordinal(3)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		public questPuppeteerNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
