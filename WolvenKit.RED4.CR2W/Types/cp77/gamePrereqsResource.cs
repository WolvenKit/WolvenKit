using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqsResource : CResource
	{
		private CArray<gamePrereqDefinition> _prereqs;

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<gamePrereqDefinition> Prereqs
		{
			get => GetProperty(ref _prereqs);
			set => SetProperty(ref _prereqs, value);
		}

		public gamePrereqsResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
