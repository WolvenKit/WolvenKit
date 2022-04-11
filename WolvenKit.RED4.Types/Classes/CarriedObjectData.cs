using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CarriedObjectData : IScriptable
	{
		[Ordinal(0)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
