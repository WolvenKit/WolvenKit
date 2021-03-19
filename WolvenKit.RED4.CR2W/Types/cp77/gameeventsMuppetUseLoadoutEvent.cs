using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsMuppetUseLoadoutEvent : redEvent
	{
		private CHandle<gamedataCPOLoadoutBase_Record> _adout;

		[Ordinal(0)] 
		[RED("adout")] 
		public CHandle<gamedataCPOLoadoutBase_Record> Adout
		{
			get => GetProperty(ref _adout);
			set => SetProperty(ref _adout, value);
		}

		public gameeventsMuppetUseLoadoutEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
