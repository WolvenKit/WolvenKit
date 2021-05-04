using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TCSInputXYAxisEvent : redEvent
	{
		private CBool _isAnyInput;

		[Ordinal(0)] 
		[RED("isAnyInput")] 
		public CBool IsAnyInput
		{
			get => GetProperty(ref _isAnyInput);
			set => SetProperty(ref _isAnyInput, value);
		}

		public TCSInputXYAxisEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
