using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPerformerSymbol : RedBaseClass
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
	}
}
