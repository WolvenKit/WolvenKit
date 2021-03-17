using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMapItem : CVariable
	{
		private CName _name;
		private CInt32 _numberOfVariations;
		private CBool _shuffle;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("numberOfVariations")] 
		public CInt32 NumberOfVariations
		{
			get => GetProperty(ref _numberOfVariations);
			set => SetProperty(ref _numberOfVariations, value);
		}

		[Ordinal(2)] 
		[RED("shuffle")] 
		public CBool Shuffle
		{
			get => GetProperty(ref _shuffle);
			set => SetProperty(ref _shuffle, value);
		}

		public audioCombatVoTriggerVariationsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
