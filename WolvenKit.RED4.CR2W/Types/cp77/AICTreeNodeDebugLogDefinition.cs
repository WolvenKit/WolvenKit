using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDebugLogDefinition : AICTreeExtendableNodeDefinition
	{
		private CString _text;
		private CFloat _timeOnScreen;
		private CBool _useVisualDebug;

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("timeOnScreen")] 
		public CFloat TimeOnScreen
		{
			get => GetProperty(ref _timeOnScreen);
			set => SetProperty(ref _timeOnScreen, value);
		}

		[Ordinal(3)] 
		[RED("useVisualDebug")] 
		public CBool UseVisualDebug
		{
			get => GetProperty(ref _useVisualDebug);
			set => SetProperty(ref _useVisualDebug, value);
		}

		public AICTreeNodeDebugLogDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
