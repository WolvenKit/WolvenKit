using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkOnscreenVOData : CVariable
	{
		private CRUID _text;

		[Ordinal(0)] 
		[RED("text")] 
		public CRUID Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		public inkOnscreenVOData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
