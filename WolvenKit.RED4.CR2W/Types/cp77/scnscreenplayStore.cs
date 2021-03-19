using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStore : CVariable
	{
		private CArray<scnscreenplayDialogLine> _lines;
		private CArray<scnscreenplayChoiceOption> _options;

		[Ordinal(0)] 
		[RED("lines")] 
		public CArray<scnscreenplayDialogLine> Lines
		{
			get => GetProperty(ref _lines);
			set => SetProperty(ref _lines, value);
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<scnscreenplayChoiceOption> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		public scnscreenplayStore(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
