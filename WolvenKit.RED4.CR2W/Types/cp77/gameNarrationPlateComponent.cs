using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNarrationPlateComponent : entIComponent
	{
		private CName _narrationCaption;
		private CName _narrationText;
		private CBool _isEnabled;

		[Ordinal(3)] 
		[RED("narrationCaption")] 
		public CName NarrationCaption
		{
			get => GetProperty(ref _narrationCaption);
			set => SetProperty(ref _narrationCaption, value);
		}

		[Ordinal(4)] 
		[RED("narrationText")] 
		public CName NarrationText
		{
			get => GetProperty(ref _narrationText);
			set => SetProperty(ref _narrationText, value);
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public gameNarrationPlateComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
