using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveStatusEffectsEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("effectTypes")] 
		public CArray<CString> EffectTypes
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(1)] 
		[RED("effectString")] 
		public CArray<CString> EffectString
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("effectTags")] 
		public CArray<CName> EffectTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public RemoveStatusEffectsEffector()
		{
			EffectTypes = new();
			EffectString = new();
			EffectTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
