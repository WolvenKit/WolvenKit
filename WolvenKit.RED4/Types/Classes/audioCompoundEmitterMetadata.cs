using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioCompoundEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("childrenNames")] 
		public CArray<CName> ChildrenNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioCompoundEmitterMetadata()
		{
			ChildrenNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
