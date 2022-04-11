using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTweakDBIDSelector : IScriptable
	{
		[Ordinal(0)] 
		[RED("baseTweakID")] 
		public TweakDBID BaseTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
