using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIComparisonPrereq : gameIPrereq
	{
		private CEnum<gameComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("comparisonType")] 
		public CEnum<gameComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}
	}
}
