using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_ObjectTagExt : worldEditorDebugColoringSettings
	{
		private CEnum<worldObjectTagExt> _tag;
		private CColor _color;

		[Ordinal(0)] 
		[RED("tag")] 
		public CEnum<worldObjectTagExt> Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		public worldDebugColoring_ObjectTagExt()
		{
			_tag = new() { Value = Enums.worldObjectTagExt.None };
		}
	}
}
