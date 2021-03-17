using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPerformerSymbol : CVariable
	{
		private scnPerformerId _performerId;
		private gameEntityReference _entityRef;
		private CRUID _editorPerformerId;

		[Ordinal(0)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(1)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(2)] 
		[RED("editorPerformerId")] 
		public CRUID EditorPerformerId
		{
			get => GetProperty(ref _editorPerformerId);
			set => SetProperty(ref _editorPerformerId, value);
		}

		public scnPerformerSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
