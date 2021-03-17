using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeLeapEvents : MeleeEventsTransition
	{
		private CUInt32 _textLayerId;

		[Ordinal(0)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetProperty(ref _textLayerId);
			set => SetProperty(ref _textLayerId, value);
		}

		public MeleeLeapEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
