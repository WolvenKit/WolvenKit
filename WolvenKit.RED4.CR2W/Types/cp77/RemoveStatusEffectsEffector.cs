using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectsEffector : gameEffector
	{
		private CArray<CString> _effectTypes;
		private CArray<CString> _effectString;
		private CArray<CName> _effectTags;

		[Ordinal(0)] 
		[RED("effectTypes")] 
		public CArray<CString> EffectTypes
		{
			get => GetProperty(ref _effectTypes);
			set => SetProperty(ref _effectTypes, value);
		}

		[Ordinal(1)] 
		[RED("effectString")] 
		public CArray<CString> EffectString
		{
			get => GetProperty(ref _effectString);
			set => SetProperty(ref _effectString, value);
		}

		[Ordinal(2)] 
		[RED("effectTags")] 
		public CArray<CName> EffectTags
		{
			get => GetProperty(ref _effectTags);
			set => SetProperty(ref _effectTags, value);
		}

		public RemoveStatusEffectsEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
