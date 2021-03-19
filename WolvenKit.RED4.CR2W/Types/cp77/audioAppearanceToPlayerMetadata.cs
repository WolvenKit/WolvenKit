using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAppearanceToPlayerMetadata : CVariable
	{
		private CArray<CName> _appearances;
		private CName _foleyPlayerMetadata;
		private CEnum<audioFoleyItemPriority> _priority;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("foleyPlayerMetadata")] 
		public CName FoleyPlayerMetadata
		{
			get => GetProperty(ref _foleyPlayerMetadata);
			set => SetProperty(ref _foleyPlayerMetadata, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<audioFoleyItemPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		public audioAppearanceToPlayerMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
