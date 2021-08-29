using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityParametersStorage : ISerializable
	{
		private CArray<CHandle<entEntityParameter>> _parameters;

		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<CHandle<entEntityParameter>> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}
	}
}
