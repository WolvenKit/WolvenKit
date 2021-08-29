using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTweakDBIDSelector : IScriptable
	{
		private TweakDBID _baseTweakID;

		[Ordinal(0)] 
		[RED("baseTweakID")] 
		public TweakDBID BaseTweakID
		{
			get => GetProperty(ref _baseTweakID);
			set => SetProperty(ref _baseTweakID, value);
		}
	}
}
