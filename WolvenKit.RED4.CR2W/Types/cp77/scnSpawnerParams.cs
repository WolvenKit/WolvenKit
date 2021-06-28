using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSpawnerParams : CVariable
	{
		private NodeRef _reference;
		private CBool _forceMaxVisibility;

		[Ordinal(0)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetProperty(ref _forceMaxVisibility);
			set => SetProperty(ref _forceMaxVisibility, value);
		}

		public scnSpawnerParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
