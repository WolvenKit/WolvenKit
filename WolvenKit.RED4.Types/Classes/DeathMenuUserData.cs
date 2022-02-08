using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathMenuUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("playInitAnimation")] 
		public CBool PlayInitAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
