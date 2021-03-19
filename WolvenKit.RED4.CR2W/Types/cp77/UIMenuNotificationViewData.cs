using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		public UIMenuNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
