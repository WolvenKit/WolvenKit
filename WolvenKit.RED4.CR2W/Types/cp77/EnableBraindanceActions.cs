using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnableBraindanceActions : redEvent
	{
		private SBraindanceInputMask _actionMask;

		[Ordinal(0)] 
		[RED("actionMask")] 
		public SBraindanceInputMask ActionMask
		{
			get => GetProperty(ref _actionMask);
			set => SetProperty(ref _actionMask, value);
		}

		public EnableBraindanceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
