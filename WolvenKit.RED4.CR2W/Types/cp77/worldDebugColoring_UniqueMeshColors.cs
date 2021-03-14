using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_UniqueMeshColors : worldEditorDebugColoringSettings
	{
		private CUInt8 _alpha;

		[Ordinal(0)] 
		[RED("alpha")] 
		public CUInt8 Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CUInt8) CR2WTypeManager.Create("Uint8", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_UniqueMeshColors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
