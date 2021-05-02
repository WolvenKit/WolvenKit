using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		private CName _textLocKey;
		private CName _textLocKey_PS4;
		private CName _textLocKey_XB1;

		[Ordinal(1)] 
		[RED("textLocKey")] 
		public CName TextLocKey
		{
			get => GetProperty(ref _textLocKey);
			set => SetProperty(ref _textLocKey, value);
		}

		[Ordinal(2)] 
		[RED("textLocKey_PS4")] 
		public CName TextLocKey_PS4
		{
			get => GetProperty(ref _textLocKey_PS4);
			set => SetProperty(ref _textLocKey_PS4, value);
		}

		[Ordinal(3)] 
		[RED("textLocKey_XB1")] 
		public CName TextLocKey_XB1
		{
			get => GetProperty(ref _textLocKey_XB1);
			set => SetProperty(ref _textLocKey_XB1, value);
		}

		public inkPlatformSpecificTextController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
