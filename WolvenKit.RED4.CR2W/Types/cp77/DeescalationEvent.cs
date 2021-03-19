using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeescalationEvent : redEvent
	{
		private CHandle<SecuritySystemInput> _originalNotification;

		[Ordinal(0)] 
		[RED("originalNotification")] 
		public CHandle<SecuritySystemInput> OriginalNotification
		{
			get => GetProperty(ref _originalNotification);
			set => SetProperty(ref _originalNotification, value);
		}

		public DeescalationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
