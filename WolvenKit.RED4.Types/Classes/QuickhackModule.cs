using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhackModule : HUDModule
	{
		[Ordinal(3)] 
		[RED("calculateClose")] 
		public CBool CalculateClose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickhackModule()
		{
			InstancesList = new();
		}
	}
}
