using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimFeature_TPPRepresentation : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("IsActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
