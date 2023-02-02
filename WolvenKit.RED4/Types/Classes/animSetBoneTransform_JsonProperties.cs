using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSetBoneTransform_JsonProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animSetBoneTransform_JsonEntry> Entries
		{
			get => GetPropertyValue<CArray<animSetBoneTransform_JsonEntry>>();
			set => SetPropertyValue<CArray<animSetBoneTransform_JsonEntry>>(value);
		}

		public animSetBoneTransform_JsonProperties()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
