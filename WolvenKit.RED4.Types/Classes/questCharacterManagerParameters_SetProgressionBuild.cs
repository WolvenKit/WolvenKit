using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_SetProgressionBuild : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("buildID")] 
		public TweakDBID BuildID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
