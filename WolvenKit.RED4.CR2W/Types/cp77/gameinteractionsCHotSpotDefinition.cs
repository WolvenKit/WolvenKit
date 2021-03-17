using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotDefinition : CVariable
	{
		private CBool _suppressor;
		private CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> _layersDefinition;

		[Ordinal(0)] 
		[RED("suppressor")] 
		public CBool Suppressor
		{
			get => GetProperty(ref _suppressor);
			set => SetProperty(ref _suppressor, value);
		}

		[Ordinal(1)] 
		[RED("layersDefinition")] 
		public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition
		{
			get => GetProperty(ref _layersDefinition);
			set => SetProperty(ref _layersDefinition, value);
		}

		public gameinteractionsCHotSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
