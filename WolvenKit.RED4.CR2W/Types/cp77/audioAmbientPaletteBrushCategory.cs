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
			get
			{
				if (_brushes == null)
				{
					_brushes = (CHandle<audioAmbientPaletteBrushDictionary>) CR2WTypeManager.Create("handle:audioAmbientPaletteBrushDictionary", "brushes", cr2w, this);
				}
				return _brushes;
			}
			set
			{
				if (_brushes == value)
				{
					return;
				}
				_brushes = value;
				PropertySet(this);
			}
		}

		public audioAmbientPaletteBrushCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
