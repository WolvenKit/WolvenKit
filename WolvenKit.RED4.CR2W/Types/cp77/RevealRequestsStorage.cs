using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealRequestsStorage : IScriptable
	{
		private CInt32 _currentRequestersAmount;
		private CArray<entEntityID> _requestersList;

		[Ordinal(0)] 
		[RED("currentRequestersAmount")] 
		public CInt32 CurrentRequestersAmount
		{
			get => GetProperty(ref _currentRequestersAmount);
			set => SetProperty(ref _currentRequestersAmount, value);
		}

		[Ordinal(1)] 
		[RED("requestersList")] 
		public CArray<entEntityID> RequestersList
		{
			get => GetProperty(ref _requestersList);
			set => SetProperty(ref _requestersList, value);
		}

		public RevealRequestsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
