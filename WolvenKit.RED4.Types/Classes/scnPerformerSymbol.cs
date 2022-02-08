using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPerformerSymbol : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("editorPerformerId")] 
		public CRUID EditorPerformerId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public scnPerformerSymbol()
		{
			PerformerId = new() { Id = 4294967040 };
			EntityRef = new() { Names = new() };
		}
	}
}
