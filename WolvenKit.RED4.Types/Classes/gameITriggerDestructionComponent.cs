using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameITriggerDestructionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("startActive")] 
		public CBool StartActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
