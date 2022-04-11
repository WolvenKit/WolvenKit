using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPuppetBreachedPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
