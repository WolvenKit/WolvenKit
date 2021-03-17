using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SUIScreenDefinition : CVariable
	{
		private TweakDBID _screenDefinition;
		private TweakDBID _style;

		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public TweakDBID ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public TweakDBID Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		public SUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
