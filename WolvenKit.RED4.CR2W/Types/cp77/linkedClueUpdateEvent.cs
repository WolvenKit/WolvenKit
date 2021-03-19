using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class linkedClueUpdateEvent : redEvent
	{
		private LinkedFocusClueData _linkedCluekData;
		private entEntityID _requesterID;
		private CBool _updatePS;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(2)] 
		[RED("updatePS")] 
		public CBool UpdatePS
		{
			get => GetProperty(ref _updatePS);
			set => SetProperty(ref _updatePS, value);
		}

		public linkedClueUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
