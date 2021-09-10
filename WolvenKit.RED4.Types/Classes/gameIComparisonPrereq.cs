using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIComparisonPrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("comparisonType")] 
		public CEnum<gameComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<gameComparisonType>>();
			set => SetPropertyValue<CEnum<gameComparisonType>>(value);
		}
	}
}
