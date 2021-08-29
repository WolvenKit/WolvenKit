using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDistanceLODsPresets : ISerializable
	{
		private CStatic<entLODDefinition> _definitions;

		[Ordinal(0)] 
		[RED("definitions", 4)] 
		public CStatic<entLODDefinition> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}
	}
}
