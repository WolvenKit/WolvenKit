using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteBrushCategory : audioAudioMetadata
	{
		private CHandle<audioAmbientPaletteBrushDictionary> _brushes;

		[Ordinal(1)] 
		[RED("brushes")] 
		public CHandle<audioAmbientPaletteBrushDictionary> Brushes
		{
			get => GetProperty(ref _brushes);
			set => SetProperty(ref _brushes, value);
		}

		public audioAmbientPaletteBrushCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
