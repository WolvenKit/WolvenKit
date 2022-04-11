using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseIShape : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
