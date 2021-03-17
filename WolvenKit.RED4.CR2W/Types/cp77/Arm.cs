using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Arm : redEvent
	{
		private wCHandle<gameObject> _requester;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		public Arm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
