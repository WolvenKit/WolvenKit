using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressOutlineEvent : redEvent
	{
		private CHandle<OutlineRequest> _requestToSuppress;

		[Ordinal(0)] 
		[RED("requestToSuppress")] 
		public CHandle<OutlineRequest> RequestToSuppress
		{
			get => GetProperty(ref _requestToSuppress);
			set => SetProperty(ref _requestToSuppress, value);
		}

		public SuppressOutlineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
