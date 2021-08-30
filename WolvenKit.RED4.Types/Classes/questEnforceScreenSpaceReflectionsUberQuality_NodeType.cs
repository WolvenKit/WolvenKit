using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnforceScreenSpaceReflectionsUberQuality_NodeType : questIRenderFxManagerNodeType
	{
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public questEnforceScreenSpaceReflectionsUberQuality_NodeType()
		{
			_enabled = true;
		}
	}
}
