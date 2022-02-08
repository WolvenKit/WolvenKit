using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityParametersStorage : ISerializable
	{
		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<CHandle<entEntityParameter>> Parameters
		{
			get => GetPropertyValue<CArray<CHandle<entEntityParameter>>>();
			set => SetPropertyValue<CArray<CHandle<entEntityParameter>>>(value);
		}

		public entEntityParametersStorage()
		{
			Parameters = new();
		}
	}
}
