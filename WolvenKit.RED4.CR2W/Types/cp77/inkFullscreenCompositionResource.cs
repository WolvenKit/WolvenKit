using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFullscreenCompositionResource : CResource
	{
		private CArray<inkCompositionPreset> _compositionPresets;
		private CHandle<inkCompositionPreviewSettings> _previewSettings;

		[Ordinal(1)] 
		[RED("compositionPresets")] 
		public CArray<inkCompositionPreset> CompositionPresets
		{
			get
			{
				if (_compositionPresets == null)
				{
					_compositionPresets = (CArray<inkCompositionPreset>) CR2WTypeManager.Create("array:inkCompositionPreset", "compositionPresets", cr2w, this);
				}
				return _compositionPresets;
			}
			set
			{
				if (_compositionPresets == value)
				{
					return;
				}
				_compositionPresets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("previewSettings")] 
		public CHandle<inkCompositionPreviewSettings> PreviewSettings
		{
			get
			{
				if (_previewSettings == null)
				{
					_previewSettings = (CHandle<inkCompositionPreviewSettings>) CR2WTypeManager.Create("handle:inkCompositionPreviewSettings", "previewSettings", cr2w, this);
				}
				return _previewSettings;
			}
			set
			{
				if (_previewSettings == value)
				{
					return;
				}
				_previewSettings = value;
				PropertySet(this);
			}
		}

		public inkFullscreenCompositionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
