using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Transition : redEvent
	{
		private CUInt32 _listenerID;

		[Ordinal(0)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetProperty(ref _listenerID);
			set => SetProperty(ref _listenerID, value);
		}

		public Transition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
