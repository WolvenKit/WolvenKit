using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteEntry : CVariable
	{
		private CName _brushCategory;

		[Ordinal(0)] 
		[RED("brushCategory")] 
		public CName BrushCategory
		{
			get
			{
				if (_brushCategory == null)
				{
					_brushCategory = (CName) CR2WTypeManager.Create("CName", "brushCategory", cr2w, this);
				}
				return _brushCategory;
			}
			set
			{
				if (_brushCategory == value)
				{
					return;
				}
				_brushCategory = value;
				PropertySet(this);
			}
		}

		public audioAmbientPaletteEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
