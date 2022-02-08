using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetArgumentBoolean : SetArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CBool CustomVar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
